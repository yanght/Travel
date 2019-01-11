using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace Travel.Domain
{
    public class SqlServerDbContext : IDbContext
    {
        private readonly string _connectionString;
        private IDbConnection _connection;

        public SqlServerDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlServerDbContext()
        {
            _connectionString = "server=116.62.208.130;database=Travel; User ID=sa;Password=yannis_123@live.com";
        }

        public IDbConnection Connection
        {
            get
            {
                try
                {
                    if (_connection == null)
                    {
                        _connection = DbConnectionFactory.CreateConnection(DatabaseType.MsSql, _connectionString);
                    }
                    if (_connection.State != ConnectionState.Open)
                    {
                        _connection.Open();
                    }
                    return _connection;
                }
                catch (Exception e)
                {
                     throw e;
                }

            }
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }


    }
}
