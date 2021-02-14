using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için, hem işlem sonucu, hem mesaj bilgilendirmesi yapma
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
