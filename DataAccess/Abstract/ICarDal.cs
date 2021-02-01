using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void GetAll();
        Car GetById(int carId);
        
        List<Car> GetByColor(int colorId);
        List<Car> GetByBrand(int brandId);

        void Add(Car car);
        void Update(Car car);
        void Delete(int Id);


        List<Color> GetColors();
        List<Brand> GetBrands();
        List<Models> GetModels();
    }
}
