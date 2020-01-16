using EF.Console.Dapper;
using EF.Console.DapperFilter.FilterAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter
{
    public class DefaultFilterator<TEntity> : IFilterator<TEntity> where TEntity : class
    {
        private IDbConnection _conn;
        private List<TEntity> _data;
        private Pager _pager;
        private List<FieldFilter> _fieldFilters;
        private Dictionary<string, object> _dict;
        private string _where;
        private string _order;
        private string _table;

        private int _count = -1;

        public DefaultFilterator(IDbConnection conn, Pager pager, List<FieldFilter> fieldFilters)
        {
            this._dict = new Dictionary<string, object>();
            this._conn = conn;
            this._pager = pager;
            this._fieldFilters = fieldFilters;
            this._where = GetWhere(this._dict);
            this._order = GetOrder();
            this._table = GetTable();

        }



        public int Count()
        {
            if (this._count > -1)
                return this._count;
            string sql = $"SELECT COUNT(1) FROM {this._table} {this._where}";
            object obj = this._conn.ExecuteScalar(sql,this._dict);
            int count = 0;
            if (obj == null)
                count = 0;
            else
                count = Convert.ToInt32(obj);
            return count;
        }

        public List<TEntity> ToList()
        {
            if (this._data != null)
                return this._data;
            IEnumerable<PropertyInfo> properties = typeof(TEntity).GetProperties().Where(x => x.CanWrite);
            List<string> fieldList = properties.Select(p => p.Name).ToList();

            if (this._order == "")
            {
                var orderProperty = properties.FirstOrDefault(x => x.Name == "ID");
                if (orderProperty == null)
                {
                    orderProperty = properties.OrderBy(p => p.Name.Length).FirstOrDefault();
                }
                _order = $"ORDER BY [{orderProperty.Name}]";
            }
            string sql = string.Empty;
            if (this._pager.PageIndex <= 1)
            {
                sql = $"SELECT TOP {this._pager.PageSize} {string.Join(",", fieldList)} FROM {_table} {_where} {_order}";
            }
            else
            {
                string subQuery = $"SELECT ROW_NUMBER() OVER({_order}) AS R, {string.Join(",", fieldList)} FROM {_table} {_where} {_order}";

                sql = $"SELECT * FROM ({subQuery}) WHERE R>@StartRow AND R<@EndRow";

                int startRow = (this._pager.PageIndex - 1) * this._pager.PageSize;
                this._dict["StartRow"] = startRow;
                this._dict["EndRow"] = startRow + this._pager.PageSize;
            }
            this._data = this._conn.Query<TEntity>(sql, this._dict).ToList();

            return this._data;
        }

        private string GetWhere(Dictionary<string, object> dict)
        {
            if (dict == null)
                throw new ArgumentException($"{nameof(DefaultFilterator<TEntity>.GetWhere)} dict is null");
            var filterWhere = this._fieldFilters.OrderBy(p => p.FieldGroup).ThenBy(p => p.FieldPriority).ToArray();
            List<string> whereList = new List<string>(filterWhere.Length);
            string temp;
            foreach (FieldFilter filter in filterWhere)
            {
                if (filter.IsValid)
                {
                    temp = filter.Build(dict);
                    if (!string.IsNullOrWhiteSpace(temp))
                    {
                        whereList.Add(temp);
                    }
                }
            }
            _where = string.Join(" AND ", whereList);
            if (_where.Length > 0)
            {
                _where = " WHERE " + _where;
            }

            return _where;
        }

        private string GetOrder()
        {
            string order = "";

            var filterOrders = this._fieldFilters.Where(x => x.Sort != 0).OrderBy(x => Math.Abs(x.Sort)).ToArray();

            foreach (FieldFilter filter in filterOrders)
            {
                order += string.Format("[{0}] {1},", filter.FieldName, filter.Sort > 0 ? "ASC" : "DESC");
            }

            order.TrimEnd(',');
            if (order.Length > 0)
            {
                order = "ORDER BY " + order;
            }
            return order;
        }

        protected virtual string GetTable()
        {
            Type entityType = typeof(TEntity);
            var tableNameAttribute = entityType.GetCustomAttributes(typeof(TableNameAttribute), true).Cast<TableNameAttribute>().FirstOrDefault();

            string tableName = tableNameAttribute == null ? entityType.Name : tableNameAttribute.Name;
            return $"[{tableName}] WITH(NOLOCK)";
        }
    }
}
