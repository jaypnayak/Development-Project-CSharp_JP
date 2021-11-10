using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Domain;
using Interview.Infrastructure.Repositories;

namespace Interview.Web.Repositories
{
    public interface IPCatRepository : IProductRepository<Product>
    {
        //placeholder for defining any custom repository methods
    }
}
