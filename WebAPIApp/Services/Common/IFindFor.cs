using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Services.Common
{
    public interface IFindFor<TResult, TKey> where TResult : class
    {
        TResult Find(TKey id);
    }
}
