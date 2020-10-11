using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Models
{
    public class InputCategory
    {
        public string Name { get; set; }
    }

    public class CategoryViewModel : InputCategory
    {
        public int Id { get; set; }
    }
}
