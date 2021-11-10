using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Infrastructure.Repositories
{
    public interface IProductRepository<T> where T : class
    {
        Task<bool> InsertToProducts(T entity);
        Task<bool> InsertToProductCategories(int instanceId);
        Task<bool> InsertToProductAttributes(int instanceId, string key, string value);
        Task<IEnumerable<T>> GetProducts(T entity);

    }
}
