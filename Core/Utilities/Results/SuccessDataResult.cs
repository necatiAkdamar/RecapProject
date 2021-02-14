using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data, true, message)//data, message ver
        {

        }

        public SuccessDataResult(T data) : base(data, true)//mesaj döndürmeyen kısım sadece data ver
        {

        }

        public SuccessDataResult(string message) : base(default,true,message)//sadece mesaj ver
        {

        }

        public SuccessDataResult() : base(default, true)//hiçbirini verme
        {

        }
    }
}
