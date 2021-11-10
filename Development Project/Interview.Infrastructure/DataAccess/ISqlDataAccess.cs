using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interview.Infrastructure.DataAccess
{
    public interface ISqlDataAccess
    {
        IDbConnection GetDbConnection();
    }
}
