using Domain.Entities;
using Skinet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Product GetProductById(int Id);
        List<Product> GetListOfproduct();
        List<ProductType> GetProductsType();
        void Add(Product product);
        void Update(Product product);
        void Delete(int Id);

    }
}
