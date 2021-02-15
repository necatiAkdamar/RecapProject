using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Business.Constants;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = carManager.GetCarDetails();//Araçları listele

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Id + " / " + car.BrandName + " / " + car.Description);
            }
            Console.WriteLine(carManager.GetCarDetails().Message);


            Console.WriteLine("\nMüşteri Ekleme_________________");
            //customerManager.Add(new Customer { CompanyName = "Çanakkale Valiliği" });


            Console.WriteLine("\nid si 14 olan Müşteriyi Silme_________________");
            //customerManager.Delete(customerManager.GetById(14).Data);
            Console.WriteLine(Messages.CustomerDeleted);

            Console.WriteLine("\nMüşteri Listeleme_________________");//müşteri listele
            foreach (var cus in customerManager.GetAll().Data)
            {
                Console.WriteLine(cus.CompanyName);
            }

            Console.WriteLine("\nKullanıcıları Listeleme_______________");
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.FirstName + " /" + item.LastName + " /" + item.Email);
            }

            Console.WriteLine("\nKullanıcı Ekleme_______________");
            //userManager.Add(new User { FirstName = "Ahmet", LastName = "Kaya", Email = "ak@gmail.com", Password = "654789" });
            Console.WriteLine(Messages.UserAdded);

            //rentalManager.Add(new Rental//aracı kiralama
            //{
            //    CarId = 5,
            //    CustomerId = 3,
            //    RentDate = DateTime.Now,
            //    ReturnDate = null
            //});
            

            foreach (var item in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(item.Id + "id'li " + item.CarDescription + " araç /" + item.UserName +" kiralama tarihi: "+ item.RentDate);
            }

        }
    }
}
