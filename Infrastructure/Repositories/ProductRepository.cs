using Domain.Entities;
using Infrastructure.Repositories;
using Skinet.Core.Entities;
using Skinet.Infrastracture.Data;
using System.Collections.Generic;
using System.Linq;

namespace Skinet.Infrastracture.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductDBContext _DbContent;
        public ProductRepository(ProductDBContext productDBContext)
        {
            _DbContent = productDBContext;
        }

        public void Add(Product product)
        {
            _DbContent.Products.Add(product);
            _DbContent.SaveChanges();
        }

        public void Update(Product product)
        {
            _DbContent.Products.Update(product);
            _DbContent.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = _DbContent.Products.FirstOrDefault(x => x.Id == Id);
            _DbContent.Products.Remove(entity);
            _DbContent.SaveChanges();
        }

        public List<Product> GetListOfproduct()
        {
            return _DbContent.Products.ToList();
        }

        public Product GetProductById(int Id)
        {
            return _DbContent.Products.FirstOrDefault(x => x.Id == Id);
        }

        public List<ProductType> GetProductsType()
        {
            return _DbContent.ProductTypes.ToList();
        }
    }
}
