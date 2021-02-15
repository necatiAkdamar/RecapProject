using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetById(int Id);
        IDataResult<List<Rental>> GetAll();//Hem data, hem mesaj, hem sonuç döndürüyor

        IResult Add(Rental rental);//Mesaj ve sonuç döndürüyor
        IResult Update(Rental rental);
        IResult Delete(Rental rental);

        IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);

    }
}
