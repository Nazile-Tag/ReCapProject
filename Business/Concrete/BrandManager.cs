using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [SecuredOperation("admin,product.add")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Add(Brand brand)
        {
            IResult result= BusinessRules.Run(CheckIfBrandNameExists(brand.BrandName), CheckIfCarCountOfBrandCorrect(brand.BrandId));
            if (result != null)
            {
                return result;
            }

            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == id));
        }
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _brandDal.Update(brand);

            return new SuccessResult(Messages.BrandUpdated);
        }

        //iş kuralı
        private IResult CheckIfCarCountOfBrandCorrect(int brandId)//15ten fazla marka ismi olamaz.
        {
            var result = _brandDal.GetAll(c => c.BrandId == brandId).Count;
            if (result >= 15)
            {
                return new ErrorResult(Messages.BrandCountOfBrandError);
            }
            return new SuccessResult();

        }

        private IResult CheckIfBrandNameExists(string brandName)//Aynı isimde marka olamaz.
        {
            var result = _brandDal.GetAll(c => c.BrandName == brandName).Any();
            if (result)
            {
                return new ErrorResult(Messages.BrandNameAlreadyExists);
            }
            return new SuccessResult();

        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Brand brand)
        {
            Add(brand);
            if (brand.BrandName.Length<=2)
            {
                throw new Exception("");
            }
            Add(brand);
            return null;
        }
    }
}
