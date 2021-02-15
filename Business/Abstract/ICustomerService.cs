using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int Id);
        IDataResult<List<Customer>> GetAll();//Hem data, hem mesaj, hem sonuç döndürüyor

        IResult Add(Customer customer);//Mesaj ve sonuç döndürüyor
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}
