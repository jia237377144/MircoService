using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter
{
    public interface IFilterator<TEntity> where TEntity :class
    {
        List<TEntity> ToList();
        int Count();
    }
}
