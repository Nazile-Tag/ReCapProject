using Core.Utilities.Results;
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

        IDataResult<Car> GetById(int carId);

        IDataResult<Car> GetAllById(int carId);

        IDataResult<CarDetailDto> GetCarDtoById(int carId);

        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);
    }
}
