using CoreDemo.DataAccess.EntityFramework;
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
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from c in context.Cars 
                             join b in context.Brands 
                             on c.CarId equals b.BrandId 
                             select new CarDetailDto { BrandId = b.BrandId, BrandName = b.BrandName, CarId = c.CarId, CarName = c.BrandName, ColorId = c.ColorId, DailyPrice = c.DailyPrice, Description = c.Description };
                return result.ToList();
            }
        }
    }

}
