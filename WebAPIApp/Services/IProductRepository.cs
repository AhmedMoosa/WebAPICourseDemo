using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Services
{
    public interface IProductRepository
    {
        void Create(string productName);
        List<string> GetAll();

        void Update(int id, string productName);
        void Delete(int id);

        string Find(int id);
    }
}
