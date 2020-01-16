using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    public sealed class CompareFieldFilter<T> : FieldFilter where T : struct, IComparable
    {
        public T? Value { get; set; }
        public CompareOperator CompareOperator { get; set; }

        public CompareFieldFilter() { }

        public CompareFieldFilter(T value)
        {
            this.Value = value;
        }

        public CompareFieldFilter(T? value)
        {
            this.Value = value;
        }

        public CompareFieldFilter(T value, CompareOperator compareOperator)
        {
            this.Value = value;
            this.CompareOperator = compareOperator;
        }

        public CompareFieldFilter(T? value, CompareOperator compareOperator)
        {
            this.Value = value;
            this.CompareOperator = compareOperator;
        }

        internal override bool IsValid => this.Value.HasValue || this.CompareOperator == CompareOperator.Null || this.CompareOperator == CompareOperator.NotNull;

        internal override string Build(Dictionary<string, object> paramDict)
        {
            string sql = "",
                vari = $"@{this.FieldName}_{paramDict.Count}";
            paramDict[vari] = this.Value;

            switch (this.CompareOperator)
            {
                case CompareOperator.Equal:
                    sql = $"[{this.FieldName}]={vari}";
                    break;
                case CompareOperator.NotEqual:
                    sql = $"[{this.FieldName}]<>{vari}";
                    break;
                case CompareOperator.GreaterThan:
                    sql = $"[{this.FieldName}]>{vari}";
                    break;
                case CompareOperator.GreaterThanEqual:
                    sql = $"[{this.FieldName}]>={vari}";
                    break;
                case CompareOperator.LessThan:
                    sql = $"[{this.FieldName}]<{vari}";
                    break;
                case CompareOperator.LessThanEqual:
                    sql = $"[{this.FieldName}]<={vari}";
                    break;
                case CompareOperator.Null:
                    sql = $"[{this.FieldName}] IS NULL";
                    break;
                case CompareOperator.NotNull:
                    sql = $"[{this.FieldName}] IS NOT NULL";
                    break;
            }
            return sql;
        }

        public static implicit operator CompareFieldFilter<T>(T value)
        {
            return new CompareFieldFilter<T>(value);
        }

        public static explicit operator T(CompareFieldFilter<T> filter)
        {
            return filter.Value.Value;
        }

        public static implicit operator CompareFieldFilter<T>(T? value)
        {
            return new CompareFieldFilter<T>(value);
        }

        public static explicit operator T?(CompareFieldFilter<T> filter)
        {
            return filter.Value;
        }

        public static implicit operator CompareFieldFilter<T>(SortPart sort)
        {
            return new CompareFieldFilter<T>() { Sort = sort };
        }
    }
}
