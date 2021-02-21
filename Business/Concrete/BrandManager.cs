using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new Result(true, Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true, Messages.BrandDeleted);
        }
                        
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true, Messages.BrandUpdated);
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll(), true, Messages.BrandListed);
        }

        IDataResult<Brand> IBrandService.GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.GetById(p => p.BrandId == id));
        }
    }
}

       
