﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Travel.Domain
{
    /// <summary>
    /// 仓储层基类，通过泛型实现通用的CRUD操作
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private IDbConnection _connection;
        public IDbContext Context { get; private set; }
        public BaseRepository(IDbContext context)
        {
            Context = context;
        }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(T model)
        {
            int? result;
            using (_connection = Context.Connection)
            {
                result = _connection.Insert<T>(model);

            }
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据ID删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            int? result;
            using (_connection = Context.Connection)
            {
                result = _connection.Delete<T>(id);
            }
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 按条件删除数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public bool DeleteList(string strWhere, object parameters)
        {
            int? result;
            using (_connection = Context.Connection)
            {
                result = _connection.DeleteList<T>(strWhere, parameters);
            }
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(T model)
        {
            int? result;
            using (_connection = Context.Connection)
            {
                result = _connection.Update<T>(model);
            }
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据ID获取实体对象
        /// </summary>
        public T GetModel(int id)
        {
            using (_connection = Context.Connection)
            {
                return _connection.Get<T>(id);
            }
        }
        /// <summary>
        /// 根据条件获取实体对象集合
        /// </summary>
        public IEnumerable<T> GetModelList(string strWhere, object parameters)
        {
            using (_connection = Context.Connection)
            {
                return _connection.GetList<T>(strWhere, parameters);
            }
        }
        /// <summary>
        /// 根据条件分页获取实体对象集合
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="rowsNum"></param>
        /// <param name="strWhere"></param>
        /// <param name="orderBy"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<T> GetListPage(int pageNum, int rowsNum, string strWhere, string orderBy, object parameters)
        {
            using (_connection = Context.Connection)
            {
                return _connection.GetListPaged<T>(pageNum, rowsNum, strWhere, orderBy, parameters); ;
            }
        }

        #endregion
    }
}