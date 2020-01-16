using Dapper;
using Dapper.Contrib.Extensions;
using JLP.IService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JLP.Service
{
    public class BaseService<T> : IDataAccess<T>, IDisposable where T : class, new()
    {
        internal IDbConnection _Conn { get; set; }
        public BaseService(IDbConnection dbConnection)
        {
            this._Conn = dbConnection;
        }

        public BaseService(String connStr)
        {
            this._Conn = new SqlConnection(connStr);
        }
        #region 新增实体
        /// <summary>
        /// 新增实体表
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public long AddNewEntity(T entity)
        {

            long id = 0;
            try
            {
                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                id = this._Conn.Insert<T>(entity);

            }
            finally
            {
                this._Conn.Close();
            }
            return id;
        }

        public long AddNewEntity(T entity, IDbTransaction dbTransaction)
        {
            long id = 0;
            try
            {
                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                id = this._Conn.Insert<T>(entity, dbTransaction);

            }
            finally
            {
                this._Conn.Close();
            }
            return id;
        }
        public bool AddNewEntityList(IEnumerable<T> entityList)
        {
            bool result = false;
            if (this._Conn.State == ConnectionState.Closed)
                this._Conn.Open();
            IDbTransaction tran = _Conn.BeginTransaction();
            try
            {
                this._Conn.Insert(entityList, tran);
                tran.Commit();
                result = true;

            }
            finally
            {
                tran.Rollback();
                this._Conn.Close();
            }
            return result;
        }
        #endregion

        #region 更新实体

        public bool UpdateEntity(T entity)
        {
            bool result = false;
            try
            {
                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                result = this._Conn.Update<T>(entity);

            }
            finally
            {
                this._Conn.Close();
            }
            return result;

        }
        public bool UpdateEntity(int id, object paras)
        {
            bool result = false;
            if (this._Conn.State == ConnectionState.Closed)
                this._Conn.Open();
            IDbTransaction tran = this._Conn.BeginTransaction();
            try
            {
                var item = this.Get(id);
                if (item != null)
                {
                    PropertyInfo[] propertyInfos = paras.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    PropertyInfo[] targetPropertyInfos = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    PropertyInfo property = null;
                    foreach (var propertyInfo in propertyInfos)
                    {
                        property = targetPropertyInfos.First(x => { return x.Name.Equals(propertyInfo.Name, StringComparison.CurrentCultureIgnoreCase); });
                        if (property != null)
                        {
                            property.SetValue(propertyInfo.GetValue(paras), item);
                        }
                    }
                    this.UpdateEntity(item);
                    tran.Commit();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }
        public bool UpdateEntity(T entity, IDbTransaction dbTransaction)
        {
            bool result = false;
            try
            {

                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                result = this._Conn.Update<T>(entity, dbTransaction);

            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }
        public bool UpdateEntityList(IEnumerable<T> entityList)
        {
            bool result = false;
            if (this._Conn.State == ConnectionState.Closed)
                this._Conn.Open();
            IDbTransaction tran = this._Conn.BeginTransaction();
            try
            {
                this._Conn.Update(entityList, tran);
                tran.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }
        #endregion


        #region 删除实体

        public bool DeleteEntity(int id)
        {
            bool result = false;
            try
            {

                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                var item = this._Conn.Get<T>(id);
                result = this._Conn.Delete<T>(item);

            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }

        public bool DeleteEntity(T entity)
        {
            bool result = false;
            try
            {

                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                result = this._Conn.Delete<T>(entity);

            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }
        public bool DeleteEntity(T entity, IDbTransaction dbTransaction)
        {
            bool result = false;
            try
            {
                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                result = this._Conn.Delete<T>(entity, dbTransaction);

            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }
        public bool DeleteEntityList(List<int> idList)
        {
            bool result = false;
            if (this._Conn.State == ConnectionState.Closed)
                this._Conn.Open();
            IDbTransaction tran = this._Conn.BeginTransaction();
            try
            {
                string sql = $"DELETE FROM {typeof(T).Name} WHERE ID IN ({string.Join(",", idList)})";
                this._Conn.Execute(sql, tran);
                tran.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }
        public bool DeleteEntityList(List<T> entityList)
        {
            bool result = false;
            if (this._Conn.State == ConnectionState.Closed)
                this._Conn.Open();
            IDbTransaction tran = this._Conn.BeginTransaction();
            try
            {
                this._Conn.Delete(entityList, tran);
                tran.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }
        public bool DeleteLogic(int id, object paras)
        {
            return this.UpdateEntity(id, paras);
        }
        #endregion


        #region 查询

        public T Get(int id)
        {
            T entity = default(T);
            try
            {
                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                entity = this._Conn.Get<T>(id);
            }
            finally
            {
                this._Conn.Close();
            }
            return entity;
        }

        public List<T> GetList(string sql)
        {
            List<T> result = default(List<T>);
            try
            {
                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                result = this._Conn.Query<T>(sql).ToList();

            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }

        public List<T> GetList(string sql, T queryEntity)
        {
            List<T> result = default(List<T>);
            try
            {
                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                result = this._Conn.Query<T>(sql, queryEntity).ToList();

            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }

        public List<T> GetList(T queryEntity)
        {
            List<T> result = default(List<T>);
            try
            {
                StringBuilder sql = new StringBuilder($"SELECT * FROM {typeof(T).Name} WHERE ");
                PropertyInfo[] propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic) ?? new PropertyInfo[0];
                List<string> parameterList = new List<string>(propertyInfos.Length) { "1 = 1" };
                foreach (var propertyInfo in propertyInfos)
                {
                    if (propertyInfo.GetValue(queryEntity) is string && string.IsNullOrWhiteSpace(propertyInfo.GetValue(queryEntity).ToString()))
                    {
                        parameterList.Add($"{propertyInfo.Name}=@{propertyInfo.Name}");
                    }
                }
                sql.Append(string.Join("AND", parameterList));


                if (this._Conn.State == ConnectionState.Closed)
                    this._Conn.Open();
                result = this._Conn.Query<T>(sql.ToString(), queryEntity).ToList();

            }
            finally
            {
                this._Conn.Close();
            }
            return result;
        }


        #endregion



        public void Dispose()
        {
            if (this._Conn != null && this._Conn.State != ConnectionState.Closed)
            {
                this._Conn.Close();
            }
        }
    }
}
