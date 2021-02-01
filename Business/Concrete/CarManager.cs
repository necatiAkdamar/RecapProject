using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;//Dataaccess katmanında bulunan Abstract sınıfını kullanabilmek için buraya injection yapıyoruz.
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(int Id)
        {
            _carDal.Delete(Id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void GetAll()
        {
            _carDal.GetAll();
        }


        public List<Brand> GetBrands()
        {
            return _carDal.GetBrands();
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _carDal.GetByBrand(brandId);
        }

        public List<Car> GetByColor(int colorId)
        {
            return _carDal.GetByColor(colorId);
        }

        public Car GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public List<Color> GetColors()
        {
            return _carDal.GetColors();
        }

        public List<Models> GetModels()
        {
            return _carDal.GetModels();
        }



    }
}
