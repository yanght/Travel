using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Travel.Domain
{
    public interface IDbContext : IDisposable
    {
        /// <summary>
        /// 数据连接
        /// </summary>
        IDbConnection Connection { get; }

    }
}
