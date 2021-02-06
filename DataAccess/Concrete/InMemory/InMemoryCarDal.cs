using DataAccess.Abstract;
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

                new Car{ CarId=1, BrandId=20, ColorId=253, ModelYear=2020, DailyPrice=300, Description="Mercedes A180" },
                new Car{ CarId=2, BrandId=21, ColorId=254, ModelYear=2020, DailyPrice=350, Description="Mercedes CLA AMG" },
                new Car{ CarId=3, BrandId=22, ColorId=255, ModelYear=2021, DailyPrice=380, Description="Mercedes CLA 200" },
                new Car{ CarId=4, BrandId=23, ColorId=256, ModelYear=2021, DailyPrice=390, Description="Mercedes CLS" },
                new Car{ CarId=5, BrandId=24, ColorId=257, ModelYear=2021, DailyPrice=400, Description="Mercedes GLB" },
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

        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
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
