using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            Success = success;
        }
        public Result(bool success, string message) : this(success)
        {
            // We can set Message here, it doesn't matter if it is readonly.
            Message = message;
        }
        public bool Success { get; }
        public string Message { get; }

        

    }
}
