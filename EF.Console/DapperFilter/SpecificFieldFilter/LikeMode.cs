using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    public enum LikeMode
    {
        /// <summary>
        /// 任何位置,相当于 like '%value%' 
        /// </summary>
        AnyWhere = 0,
        /// <summary>
        /// 开始处,相当于 like 'value%'
        /// </summary>
        Start = 1,
        /// <summary>
        /// 结尾处,相当于 like '%value' 
        /// </summary>
        End = 2,
        /// <summary>
        /// 精确匹配,相当于 like 'value'
        /// </summary>
        Exact = 3,
        /// <summary>
        /// 空值
        /// </summary>
        EmptyOrNull = 4,
        /// <summary>
        /// 不存在任何位置,相当于not  like '%value%' 
        /// </summary>
        NotAnyWhere = 5,
        /// <summary>
        /// 不存在开始处,相当于not  like 'value%'
        /// </summary>
        NotStart = 6,
        /// <summary>
        /// 不存在结尾处,相当于not  like '%value' 
        /// </summary>
        NotEnd = 7,
        /// <summary>
        /// 不存在精确匹配,相当于not  like 'value'
        /// </summary>
        NotExact = 8,
        /// <summary>
        /// 有值
        /// </summary>
        NotNullAndNotEmpty = 9,
        /// <summary>
        /// 全文检索
        /// </summary>
        FullText = 10
    }
}
