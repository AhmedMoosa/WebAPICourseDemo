using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Services
{
    //fake NMoq , NUnit , MsTest >> Unit Testing. >> Test Cases 
    public class EfProductRepository : IProductRepository
    {
        public void Create(string productName)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string productName)
        {
            throw new NotImplementedException();
        }
    }
}
