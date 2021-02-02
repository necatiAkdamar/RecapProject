using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        List<Color> _colors;
        List<Brand> _brands;
        List<Models> _models;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1, BrandId=1, ModelId=1, ColorId=1, ModelYear="2015",DailyPrice=200,Description="Güzel Araba 1"},
                new Car{Id=2, BrandId=2, ModelId=3, ColorId=2, ModelYear="2018",DailyPrice=375,Description="Güzel Araba 2"},
                new Car{Id=3, BrandId=3, ModelId=5, ColorId=3, ModelYear="2015",DailyPrice=150,Description="Güzel Araba 3"},
                new Car{Id=4, BrandId=4, ModelId=7, ColorId=2, ModelYear="2019",DailyPrice=180,Description="Güzel Araba 4"},
                new Car{Id=5, BrandId=4, ModelId=8, ColorId=2, ModelYear="2019",DailyPrice=210,Description="Güzel Araba 5"},
                new Car{Id=6, BrandId=1, ModelId=2, ColorId=3, ModelYear="2016",DailyPrice=150,Description="Güzel Araba 6"},
                new Car{Id=7, BrandId=2, ModelId=4, ColorId=3, ModelYear="2011",DailyPrice=280,Description="Güzel Araba 7"},
                new Car{Id=8, BrandId=2, ModelId=3, ColorId=1, ModelYear="2011",DailyPrice=310,Description="Güzel Araba 8"},
                new Car{Id=9, BrandId=3, ModelId=6, ColorId=1, ModelYear="2010",DailyPrice=120,Description="Güzel Araba 9"},
                new Car{Id=10, BrandId=2,ModelId=4, ColorId=1, ModelYear="2012",DailyPrice=330,Description="Güzel Araba 10"}
            };

            _colors = new List<Color>
            {
                new Color{ColorId=1, ColorName="Red"},
                new Color{ColorId=2, ColorName="Blue"},
                new Color{ColorId=3, ColorName="White"}
            };

            _brands = new List<Brand>
            {
                new Brand{BrandId=1, BrandName="Opel    "},
                new Brand{BrandId=2, BrandName="Mercedes"},
                new Brand{BrandId=3, BrandName="Renault "},
                new Brand{BrandId=4, BrandName="Skoda   "}
            };

            _models = new List<Models>
            {
                new Models{BrandId=1, ModelId=1, ModelName="Astra "},
                new Models{BrandId=1, ModelId=2, ModelName="Corsa "},
                new Models{BrandId=2, ModelId=3, ModelName="C180  "},
                new Models{BrandId=2, ModelId=4, ModelName="B200  "},
                new Models{BrandId=3, ModelId=5, ModelName="Megane"},
                new Models{BrandId=3, ModelId=6, ModelName="Clio  "},
                new Models{BrandId=4, ModelId=7, ModelName="Octavia"},
                new Models{BrandId=4, ModelId=8, ModelName="Yeti  "}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(int Id)
        {
            Car deleteCar = _car.SingleOrDefault(p => p.Id == Id);
            _car.Remove(deleteCar);
            Console.WriteLine($"{Id} id numaralı araç listeden silinmiştir.");
        }

        public void GetAll()
        {
            var araclar = (from arac in _car
                           join marka in _brands on arac.BrandId equals marka.BrandId
                           join model in _models on arac.ModelId equals model.ModelId
                           join renk in _colors on arac.ColorId equals renk.ColorId

                           select new
                           {
                               markaAdi = marka.BrandName,
                               modelAdi = model.ModelName,
                               modelYili = arac.ModelYear,
                               kira = arac.DailyPrice,
                               aciklama = arac.Description,
                               renk=renk.ColorName}).ToList();
            Console.WriteLine("Marka\t\tModel\t\tGünlük Kira\tRenk\t\tAçıklama");
            foreach (var item in araclar)
            {
                Console.WriteLine($"{item.markaAdi}\t{item.modelYili}, {item.modelAdi}\t{item.kira}\t\t{item.renk}\t{item.aciklama}");
            }            
        }

        public List<Brand> GetBrands()//Markaları Listele
        {
            return _brands;
        }

        public List<Car> GetByBrand(int brandId)//Markaya göre listele
        {
            return _car.Where(p => p.BrandId == brandId).ToList();            
        }

        public List<Car> GetByColor(int colorId)//Renge göre listele
        {
            return _car.Where(p => p.ColorId == colorId).ToList();
        }

        public Car GetById(int carId)
        {
            return _car.SingleOrDefault(p => p.Id == carId);            
        }

        public List<Color> GetColors()
        {
            return _colors;
        }

        public List<Models> GetModels()
        {
            return _models;
        }

        public void Update(Car car)
        {
            Car carUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carUpdate.Id = car.Id;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelId = car.ModelId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }

    }
        
}


