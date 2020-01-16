using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.FilterAttribute
{
    /// <summary>
    /// 类型特性,通过该标记可以对同一类型的过滤器进行优先级的设定，即where 列的排序问题，比如 IdFieldFilter 可能比 LikeFilter 要靠前
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FieldGroupAttribute : Attribute
    {
        private int _priority = 0;
        public int Priority { get { return this._priority; } }

        public FieldGroupAttribute() { }

        public FieldGroupAttribute(int priority)
        {
            this._priority = priority;
        }

    }
}
