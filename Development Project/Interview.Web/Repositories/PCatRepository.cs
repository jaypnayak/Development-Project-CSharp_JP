using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Infrastructure.Repositories;
using Interview.Infrastructure.DataAccess;
using Interview.Domain;
using Interview.Web.Models;
using Dapper;

namespace Interview.Web.Repositories
{
    public class PCatRepository : ProductRepository<Product>, IPCatRepository
    {
        public PCatRepository(ISqlDataAccess dbProvider) : base(dbProvider) { }


        public override async Task<IEnumerable<Product>> GetProducts(Product request)
        {
            return await Connection.QueryAsync<Product>("SELECT * from [Instances].[dbo].[Products] WHERE Name like '%@Name%' OR Description like '%@Description%' OR ValidSkus = @ValidSkus", new { request.Name, request.Description, request.ValidSkus });
        }

        public override Task<bool> InsertToProductAttributes(int instanceId, string key, string value)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> InsertToProductCategories(int instanceId)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> InsertToProducts(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
