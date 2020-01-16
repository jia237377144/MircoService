using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    public class IdFieldFilter<T> : FieldFilter where T : struct, IComparable
    {
        public T? Value { get; set; }
        internal override bool IsValid => this.Value.HasValue;

        public IdFieldFilter() { }
        public IdFieldFilter(T value)
        {
            this.Value = value;
        }

        internal override string Build(Dictionary<string, object> paramDict)
        {
            string vari = $"@{base.FieldName}_{paramDict.Count}";
            paramDict[vari] = this.Value;
            return $"[{base.FieldName}]={vari}";
        }

        /// <summary>
        /// 把 T 类型隐式转换为 IdFieldFilter<T>
        /// 因为在请求时 需要通过NewtenSoft序列化，这就要求能够隐式转换为需要的类型
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator IdFieldFilter<T>(T value)
        {
            return new IdFieldFilter<T>(value);
        }
        public static explicit operator T(IdFieldFilter<T> filter)
        {
            return filter.Value.Value;
        }

        public static implicit operator IdFieldFilter<T>(T? value)
        {
            return new IdFieldFilter<T>(value.Value);
        }
        public static explicit operator T?(IdFieldFilter<T> filter)
        {
            return filter.Value.Value;
        }

        public static implicit operator IdFieldFilter<T>(SortPart sortPart)
        {
            return new IdFieldFilter<T> { Sort = sortPart };
        }
    }
}
