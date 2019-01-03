using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Travel.Domain
{
    /// <summary>
    /// 连接工厂类
    /// </summary>
    public class DbConnectionFactory
    {
        public static IDbConnection CreateConnection(DatabaseType database, string connection)
        {
            IDbConnection conn = null;
            switch (database)
            {
                case DatabaseType.MsSql:
                    conn = new SqlConnection(connection);
                    break;
                case DatabaseType.MySql:
                    conn = new MySqlConnection(connection);
                    break;
                default:
                    conn = new SqlConnection(connection);
                    break;
            }
            return conn;
        }
    }
}
