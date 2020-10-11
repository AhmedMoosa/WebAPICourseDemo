using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp.Models;

namespace WebAPIApp.Services
{
    public interface ICRUDOperationsFor<TInput, TResult, TKey> where TInput : class where TResult : class
    {
        OperationResult Create(TInput model);

        IQueryable<TResult> GetAll();

        TResult Find(TKey id);

        OperationResult Update(TKey id, TInput model);

        OperationResult Delete(TKey id);
    }
}
