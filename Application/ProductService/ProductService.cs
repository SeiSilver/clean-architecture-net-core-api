using Application.ProductService;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Skinet.Application.CustomServices
{
    public class ProductService : IProductService<Product>
    {
        public void Delete(Product entity)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
