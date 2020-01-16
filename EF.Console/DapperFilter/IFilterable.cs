using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter
{
    /// <summary>
    /// Filter基础接口
    /// </summary>
    public interface IFilterable
    {
        Pager Pager { get; set; }

        void AddFilter(string fieldName, FieldFilter fieldFilter, int fieldPriority = 0);

    }

    public interface IFilterable<TEntity>:IFilterable where TEntity:class
    {
        IFilterator<TEntity> GetFilterator(IDbConnection conn);
    }
}
