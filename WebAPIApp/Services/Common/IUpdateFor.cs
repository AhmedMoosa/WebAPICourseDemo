using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp.Models;

namespace WebAPIApp.Services.Common
{
    public interface IUpdateFor<TInput, TKey> where TInput : class
    {
        OperationResult Update(TKey id, TInput model);
    }
}
