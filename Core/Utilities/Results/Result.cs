using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success) //result'ın tek parametreli olan contructor'una succesi yolla
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        //get readony dir contructor dışında set edilemez
        public bool Success { get; }

        public string Message { get; }
    }
}
