using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp.Models;

namespace WebAPIApp.Services.Common
{
    public interface IDeleteFor<TKey>
    {
        OperationResult Delete(TKey id);
    }
}
