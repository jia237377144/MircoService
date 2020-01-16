using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    public class RangeFieldFilter<T> : FieldFilter where T : struct, IComparable
    {
        public T? StartValue { get; set; }
        public T? EndValue { get; set; }


        internal override bool IsValid => this.StartValue.HasValue || this.EndValue.HasValue;

        public RangeFieldFilter() { }
        public RangeFieldFilter(T startValue, T endValue)
        {
            this.StartValue = startValue;
            this.EndValue = endValue;
        }
        public RangeFieldFilter(T? startValue, T? endValue)
        {
            this.StartValue = startValue;
            this.EndValue = endValue;
        }

        internal override string Build(Dictionary<string, object> paramDict)
        {
            string sql = "",
                vari = $"@{this.FieldName}_{paramDict.Count}";
            if (this.StartValue.HasValue && this.EndValue.HasValue)
            {
                paramDict[vari + "_1"] = this.StartValue;
                paramDict[vari + "_2"] = this.EndValue;
                sql = $"[{this.FieldName}] BETWEEN {vari + "_1"} AND {vari + "_2"}";
            }
            else if (this.StartValue.HasValue)
            {
                paramDict[vari] = this.StartValue;
                sql = $"[{this.FieldName}]>{vari}";
            }
            else if (this.EndValue.HasValue)
            {
                paramDict[vari] = this.EndValue;
                sql = $"[{this.FieldName}]<{vari}";
            }
            return sql;
        }

        public static implicit operator RangeFieldFilter<T>(T[] value)
        {
            return new RangeFieldFilter<T>(value[0], value[1]);
        }
        public static explicit operator T[](RangeFieldFilter<T> filter)
        {
            return new T[2] { filter.StartValue.Value, filter.EndValue.Value };
        }

        public static implicit operator RangeFieldFilter<T>(T?[] value)
        {
            return new RangeFieldFilter<T>(value[0], value[1]);
        }
        public static explicit operator T?[](RangeFieldFilter<T> filter)
        {
            return new T?[2] { filter.StartValue, filter.EndValue };
        }

        public static implicit operator RangeFieldFilter<T>(SortPart sort)
        {
            return new RangeFieldFilter<T> { Sort = sort };
        }


    }
}
