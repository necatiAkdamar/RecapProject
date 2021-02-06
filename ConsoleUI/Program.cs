using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());


            Console.WriteLine("Brand Id'si 3 olan arabalar: \nId\tBrand Name\tColor Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine($"{car.Id}\t{brandManager.GetById(car.BrandId).BrandName}\t{colorManager.GetById(car.ColorId).ColorName}\t\t {car.ModelYear}\t {car.DailyPrice}\t {car.Description}");
            }
            Console.WriteLine("*****************************");

            Console.WriteLine("Color Id'si 2 olan arabalar: \nId\tBrand\t\tColor\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine($"{car.Id}\t{brandManager.GetById(car.BrandId).BrandName}\t{colorManager.GetById(car.ColorId).ColorName}\t {car.ModelYear}\t {car.DailyPrice}\t {car.Description}");
            }
            Console.WriteLine("*****************************");
            foreach (var c in brandManager.GetAll())
            {
                Console.WriteLine(c.BrandName);
            }
            
        }
    }
}
