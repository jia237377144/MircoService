using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.FilterAttribute
{
    /// <summary>
    /// 类型值特性,通过该标记可以对同一类型下的所有过滤器进行优先级的设定，比如CompareFieldFilter类型的 年龄 和 身高两个字段 中 年龄可以比身高优先级高
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FieldFilterAttribute : Attribute
    {
        /// <summary>
        /// 优先级（排序？？还是字段where位置？？）
        /// </summary>
        private int _priority = 0;
        /// <summary>
        /// 指定字段名称
        /// </summary>
        private string _name;
        public int Priority
        {
            get
            {
                return this._priority;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public FieldFilterAttribute() { }
        public FieldFilterAttribute(int priority)
        {
            this._priority = priority;
        }
        public FieldFilterAttribute(string name)
        {
            this._name = name;
        }
        public FieldFilterAttribute(int priority, string name)
        {
            this._priority = priority;
            this._name = name;
        }

    }
}
