using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool//toollar genellikle static olur. 
    {
        public static void Validate(IValidator validator, object entity) //Bu methotu her yerde çalıştırabiliriz.
        {
            var context = new ValidationContext<object>(entity);//CarValidator da tanımladığımız kuralları kullanmak için
            
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
