using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult//IResult implementasyonu ile mesaj ve işlem sonucu dışında içeriğinde
    {
        T Data { get; }//birde data barındırıyor
    }
}
