using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int Id);
        IDataResult<List<Car>> GetAll();//Hem data, hem mesaj, hem sonuç döndürüyor
        IDataResult<List<CarDetailDto>> GetCarDetails();
       
        IResult Add(Car car);//Mesaj ve sonuç döndürüyor
        IResult Update(Car car);
        IResult Delete(Car car);            
    }
}
