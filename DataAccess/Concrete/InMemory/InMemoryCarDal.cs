﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                new Car{ CarId=1, BrandId=1, BrandName="Mercedes", ColorId=1, ModelYear=2020, DailyPrice=300, Description="Dizel,Otomatik Vites" },
                new Car{ CarId=2, BrandId=2, BrandName="BMW", ColorId=2, ModelYear=2020, DailyPrice=350, Description="Benzin,Otomatik Vites" },
                new Car{ CarId=3, BrandId=3, BrandName="Audi", ColorId=3, ModelYear=2021, DailyPrice=380, Description="Dizel,Otomatik Vites" },
                new Car{ CarId=4, BrandId=4, BrandName="Toyota", ColorId=4, ModelYear=2021, DailyPrice=390, Description="Dizel,Otomatik Vites" },
                new Car{ CarId=5, BrandId=5, BrandName="Hyundai", ColorId=5, ModelYear=2021, DailyPrice=400, Description="Benzin,Otomatik Vites" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }

}
