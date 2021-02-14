using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>//Sen bir Result sın
    {
        public DataResult(T data, bool success, string message):base(success,message)//base e success ve message ı gönderir.
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success)//base e yani Result a success i gönderir
        {
            Data = data;
        }
        public T Data { get; }
    }
}
