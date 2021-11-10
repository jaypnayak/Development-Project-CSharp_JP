using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Interview.Infrastructure.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        public string _connectionString;

        public SqlDataAccess(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public IDbConnection GetDbConnection()
        {
            return new SqlConnection(this._connectionString);
        }
    }
}
