using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Services.Common
{
    public interface IGetAllFor<TResult> where TResult : class
    {
        IQueryable<TResult> GetAll();
    }
}
