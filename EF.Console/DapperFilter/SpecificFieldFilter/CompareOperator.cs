using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    /// <summary>
    /// 比较操作符
    /// </summary>
    public enum CompareOperator
    {
        /// <summary>
        /// 等于
        /// </summary>
        Equal = 0,
        /// <summary>
        /// 不等于
        /// </summary>
        NotEqual = 1,
        /// <summary>
        /// 大于
        /// </summary>
        GreaterThan = 2,
        /// <summary>
        /// 大于等于
        /// </summary>
        GreaterThanEqual = 3,
        /// <summary>
        /// 小于
        /// </summary>
        LessThan = 4,
        /// <summary>
        /// 小于等于
        /// </summary>
        LessThanEqual = 5,
        /// <summary>
        /// 无值
        /// </summary>
        Null = 6,
        /// <summary>
        /// 有值
        /// </summary>
        NotNull = 7
    }
}
