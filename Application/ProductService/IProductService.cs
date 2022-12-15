using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductService
{
    public interface IProductService<T>
    {
        IEnumerable<T> GetAll();
        void FindById(int Id);
        void Add(T entity);
        Task<T> Update(T entity);
        void Delete(T entity);
    }

}
