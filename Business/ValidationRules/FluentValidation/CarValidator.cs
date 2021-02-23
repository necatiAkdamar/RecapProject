using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            //Car için kurallarımız buraya yazılır.
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(5);//description min 5 karakter olmalıdır.
            RuleFor(p => p.DailyPrice).NotEmpty();//günlük fiyat boş geçilemez
            
        }
    }
}
