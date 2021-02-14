using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {        
        public Result(bool success, string message):this(success)//tek parametre geldiğinde message çalışacak 2 parametre geldiğinde succes sonucu ile birlikte message çalışacak
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
