using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success)
        {
            Success = success;
        }

        // NOT repeating a line in constructor, instead we use th is method to execute both constructors
        public Result(bool success, string message) : this(success) 
        {
            Message = message;  
            
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
