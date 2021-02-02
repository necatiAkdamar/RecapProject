using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var color in carManager.GetColors())//Tüm Renkler
            {
                Console.WriteLine($"Renk ID:{color.ColorId} = {color.ColorName}");
            }

            foreach (var brand in carManager.GetBrands())//Tüm Markalar
            {
                Console.WriteLine($"Marka ID:{brand.BrandId} = {brand.BrandName}");
            }
            Console.WriteLine("***********************************");
            foreach (var model in carManager.GetModels())//Tüm Modeller
            {
                Console.WriteLine($"Model ID:{model.ModelId} = {model.ModelName}");
            }
            Console.WriteLine("***********************************");
            
            carManager.Add(new Car{ Id = 11, BrandId = 2, ModelId = 3, ColorId = 3, 
                ModelYear = "2020", DailyPrice = 400, Description = "Yeni Güzel Mercedes"});//Araç Ekleme

            carManager.Update(new Car//Araç güncelleme
            {
                Id = 11,
                BrandId = 2,
                ModelId = 4,
                ColorId = 3,
                ModelYear = "1995",
                DailyPrice = 50,
                Description = "Güncellenen Güzel Mercedes"
            });
                        
            carManager.Delete(5);//Araç Silme

            Console.WriteLine("***********************************");

            carManager.GetAll(); //LINQ join kullanarak tüm araçları listeleme.

            
        }
    }
}
