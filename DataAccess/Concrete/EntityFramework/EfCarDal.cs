using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto,bool>> filter =null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ImagePath = context.CarImages.Where(x => x.CarId == car.CarId).Select(x => x.ImagePath).SingleOrDefault()
                             };

                return result.ToList();
            }
        }
        
    }

}