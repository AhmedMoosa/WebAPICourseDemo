using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Models
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }


        public static OperationResult Successed(string msg = "Operation Completed Successfully!.")
        {
            return new OperationResult { Success = true, Message = msg };
        }

        public static OperationResult NotFound(string msg = "Item Not Found!.")
        {
            return new OperationResult { Success = false, Message = msg };
        }
    }
}
