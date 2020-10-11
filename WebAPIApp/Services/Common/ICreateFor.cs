using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp.Models;

namespace WebAPIApp.Services.Common
{
    public interface ICreateFor<TInput> where TInput : class
    {
        OperationResult Create(TInput model);
    }
}
