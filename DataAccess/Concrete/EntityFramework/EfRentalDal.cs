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
                             join car in context.Car
                             on rent.CarId equals car.Id
                             join us in context.User
                             on rent.CustomerId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = rent.Id,
                                 CarId = car.Id,
                                 CarDescription = car.Description,                                 
                                 UserName = us.FirstName + " " + us.LastName,                                 
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate
                             };

                return result.ToList();
            }
        }

        
    }
}

