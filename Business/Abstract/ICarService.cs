﻿using CoreDemo.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetAllByCarId(int id);

        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> GetById(int carId);

        IResult Add(Car car);
    }
}
