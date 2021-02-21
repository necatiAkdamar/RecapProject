using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentaCarContext>, IRentalDal
    {
        
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from rent in context.Rental
                             join car in context.Car on rent.CarId equals car.Id
                             join b in context.Brand on car.BrandId equals b.BrandId
                             join c in context.Customer on rent.CustomerId equals c.CustomerId
                             join us in context.User on c.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = rent.Id,
                                 BrandName=b.BrandName +" markalı "+ car.Description,
                                 CustomerName= us.FirstName +" "+us.LastName,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate
                             };
                return result.ToList();
            }
        }                
    }
}
