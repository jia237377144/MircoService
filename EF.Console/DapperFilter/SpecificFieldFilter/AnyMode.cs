using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    /// <summary>
    /// 多值模式
    /// </summary>
    public enum AnyMode
    {
        /// <summary>
        /// 包含这些值
        /// </summary>
        Contain = 0,
        /// <summary>
        /// 排除这些值
        /// </summary>
        Exclude = 1
    }
}
