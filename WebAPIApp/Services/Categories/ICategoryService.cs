using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp.Models;
using WebAPIApp.Services.Common;

namespace WebAPIApp.Services.Categories
{
    public interface ICategoryService : //ICRUDOperationsFor<InputCategory, CategoryViewModel, int>
        ICreateFor<InputCategory>,
        IUpdateFor<InputCategory, int>,
        IFindFor<CategoryViewModel, int>,
        IGetAllFor<CategoryViewModel>,
        IDeleteFor<int>
    {
        //"Error" && "Successed"

    }
}
