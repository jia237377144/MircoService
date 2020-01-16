using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter
{
    /// <summary>
    /// 筛选抽象基类
    /// </summary>
    public abstract class FieldFilter
    {
        /// <summary>
        /// 获取或者设置 排序.(数值的绝对值大小代表排序的优先级，1的优先级比10的优先级高,-1和1的优先级一样高。)
        /// <para> </para>
        /// <para>  负数：倒序，如 -1,-2</para>
        /// <para>  正数：正序，如 2,3</para>
        /// <para>  0：不排序(默认值)</para>
        /// </summary>
        /// </summary>
        public int Sort { get; set; }
        internal string FieldName { get; set; }

        internal int FieldPriority { get; set; }

        internal int FieldGroup { get; set; }

        internal PropertyInfo Property { get; set; }

        internal abstract bool IsValid { get; }

        internal abstract string Build(Dictionary<string, object> paramDict);


        public FieldFilter()
        {
            this.Sort = 0;
        }
    }
}
