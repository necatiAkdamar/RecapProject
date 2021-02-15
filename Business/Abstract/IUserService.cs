using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int Id);
        IDataResult<List<User>> GetAll();//Hem data, hem mesaj, hem sonuç döndürüyor
        
        IResult Add(User user);//Mesaj ve sonuç döndürüyor
        IResult Update(User user);
        IResult Delete(User user);
    }
}
