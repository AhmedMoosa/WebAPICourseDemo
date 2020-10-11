using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Services
{
    public class ProductRepository : IProductRepository
    {
        //XML 
        public void Create(string productName)
        {
            //Created ;
            int x = 3;
            //  ........
            if (x == 5)
            {
                return;
            }
            //....
            if (x > 10)
            {

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Find(int id)
        {
            return "Ahmed Moosa";
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
