using EF.Console.DapperFilter.FilterAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter
{
    public abstract class Filterable<TEntity> : IFilterable<TEntity> where TEntity : class
    {
        private static readonly Type FiledFilterType = typeof(FieldFilter);
        protected readonly List<FieldFilter> customFilters = new List<FieldFilter>();


        /// <summary>
        /// 分页，默认pageindex:1,pagesize:20
        /// </summary>
        public Pager Pager { get; set; }

        public IFilterator<TEntity> GetFilterator(IDbConnection conn)
        {
            var properties = this.GetType().GetProperties().Where(p => p.PropertyType.IsSubclassOf(FiledFilterType));

            var filters = new List<FieldFilter>();
            int i = 10;

            foreach (var item in properties)
            {
                i += 10;
                //这里直接将 值类型 隐式转换为 FieldFilter
                var field = item.GetValue(this, null) as FieldFilter;
                if (field == null)
                {
                    continue;
                }

                field.Property = item;

                var fieldFilterAttribute = item.GetCustomAttributes(typeof(FieldFilterAttribute), true).Cast<FieldFilterAttribute>().FirstOrDefault();
                if (fieldFilterAttribute != null)
                {
                    field.FieldName = fieldFilterAttribute.Name ?? item.Name;
                    field.FieldPriority = fieldFilterAttribute.Priority;
                }
                else
                {
                    field.FieldName = item.Name;
                    field.FieldPriority = i;
                }

                var fieldGroupAttribute = item.GetCustomAttributes(typeof(FieldGroupAttribute), true).Cast<FieldGroupAttribute>().FirstOrDefault();

                if(fieldGroupAttribute!=null)
                {
                    field.FieldGroup = fieldGroupAttribute.Priority;
                }
                else
                {
                    field.FieldGroup = int.MaxValue;
                }

                filters.Add(field);
            }


            if(this.customFilters.Count>0)
            {
                filters = filters.Concat(this.customFilters).ToList();
            }

            if(Pager==null)
            {
                Pager = new Pager();
            }
            return new DefaultFilterator<TEntity>(conn, Pager, filters);
        }

        public void AddFilter(string fieldName, FieldFilter fieldFilter, int fieldPriority = 0)
        {
            throw new NotImplementedException();
        }

    }
}
