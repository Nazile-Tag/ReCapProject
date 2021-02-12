using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carsDal;

        public CarManager(ICarDal carsDal)
        {
            _carsDal = carsDal;
        }

        public List<Car> GetAll()
        {
            return _carsDal.GetAll();
        }

        public List<Car> GetAllByCarId(int id)
        {
            return _carsDal.GetAll(c => c.CarId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carsDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carsDal.GetCarDetails();
        }
    }
}
