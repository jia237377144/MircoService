using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    public class AnyFieldFilter<T> : FieldFilter where T : struct, IComparable
    {
        public IEnumerable<T> Value { get; set; }
        public AnyMode AnyMode { get; set; }

        public AnyFieldFilter() { }

        public AnyFieldFilter(T value) : this(new List<T> { value }, AnyMode.Contain)
        {
        }

        public AnyFieldFilter(IEnumerable<T> value) : this(value, AnyMode.Contain)
        { }



        public AnyFieldFilter(IEnumerable<T> value, AnyMode anyMode)
        {
            this.Value = value;
            this.AnyMode = anyMode;
        }





        internal override bool IsValid => this.Value != null && this.Value.Count() != 0;

        internal override string Build(Dictionary<string, object> paramDict)
        {
            string sql = "",
                vari = $"@{this.FieldName}_{paramDict.Count}";
            switch (this.AnyMode)
            {
                case AnyMode.Contain:
                    if (this.Value.Count() == 1)
                    {
                        paramDict.Add(vari, this.Value.First());
                        sql = $"[{this.FieldName}] = {vari}";
                    }
                    else
                    {
                        paramDict.Add(vari, this.Value);
                        sql = $"[{this.FieldName}] IN {vari}";
                    }
                    break;
                case AnyMode.Exclude:
                    if (this.Value.Count() == 1)
                    {
                        paramDict.Add(vari, this.Value.First());
                        sql = $"[{this.FieldName}] <> {vari}";
                    }
                    else
                    {
                        paramDict.Add(vari, this.Value);
                        sql = $"[{this.FieldName}] NOT IN {vari}";
                    }
                    break;
            }
            return sql;
        }

        public static explicit operator List<T>(AnyFieldFilter<T> value)
        {
            return value.Value.ToList();
        }
        public static implicit operator AnyFieldFilter<T>(List<T> value)
        {
            return new AnyFieldFilter<T>(value);
        }

        public static explicit operator T[](AnyFieldFilter<T> value)
        {
            return value.Value.ToArray();
        }
        public static implicit operator AnyFieldFilter<T>(T[] value)
        {
            return new AnyFieldFilter<T>(value);
        }

        public static implicit operator AnyFieldFilter<T>(T value)
        {
            return new AnyFieldFilter<T>(new[] { value });
        }
        public static implicit operator AnyFieldFilter<T>(SortPart value)
        {
            return new AnyFieldFilter<T>() { Sort = value };
        }

        public override string ToString()
        {
            return $"{this.FieldName}: {string.Join(",", this.Value)}";
        }
    }
}
