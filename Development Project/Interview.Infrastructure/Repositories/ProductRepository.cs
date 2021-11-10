using Interview.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Infrastructure.Repositories
{
    public abstract class ProductRepository<T> : IProductRepository<T> where T: class
    {
        protected IDbConnection Connection { get; }
        
        public ProductRepository(ISqlDataAccess sqlDataAccess)
        {
            Connection = sqlDataAccess.GetDbConnection();
            Connection.Open();
        }
        public abstract Task<bool> InsertToProducts(T entity);
        public abstract Task<bool> InsertToProductCategories(int instanceId);
        public abstract Task<bool> InsertToProductAttributes(int instanceId, string key, string value);
        public abstract Task<IEnumerable<T>> GetProducts(T entity);
    }
}
