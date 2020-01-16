using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.SpecificFieldFilter
{
    public class LikeFieldFilter : FieldFilter
    {
        public string Value { get; set; }
        /// <summary>
        /// 匹配模式，默认 AnyWhere
        /// </summary>
        public LikeMode Mode { get; set; }
        internal override bool IsValid => !string.IsNullOrEmpty(Value) || Mode == LikeMode.EmptyOrNull || Mode == LikeMode.NotNullAndNotEmpty;

        /// <summary>
        ///
        /// </summary>
        public LikeFieldFilter()
        {
            Mode = LikeMode.AnyWhere;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        public LikeFieldFilter(string value)
            : this(value, LikeMode.AnyWhere)
        {
        }
        public LikeFieldFilter(char value)
            : this(value.ToString(), LikeMode.AnyWhere)
        {
        }
        public LikeFieldFilter(int value)
            : this(value.ToString(), LikeMode.AnyWhere)
        {
        }
        public LikeFieldFilter(long value)
            : this(value.ToString(), LikeMode.AnyWhere)
        {
        }
        public LikeFieldFilter(float value)
            : this(value.ToString(), LikeMode.AnyWhere)
        {
        }
        public LikeFieldFilter(double value)
            : this(value.ToString(), LikeMode.AnyWhere)
        {
        }
        public LikeFieldFilter(decimal value)
            : this(value.ToString(), LikeMode.AnyWhere)
        {
        }
        public LikeFieldFilter(IConvertible value)
            : this(value.ToString(), LikeMode.AnyWhere)
        {
        }

        public LikeFieldFilter(string value, LikeMode likeMode)
        {
            Value = value;
            Mode = likeMode;
        }
        public LikeFieldFilter(char value, LikeMode likeMode)
            : this(value.ToString(), likeMode)
        {
        }
        public LikeFieldFilter(int value, LikeMode likeMode)
            : this(value.ToString(), likeMode)
        {
        }
        public LikeFieldFilter(long value, LikeMode likeMode)
            : this(value.ToString(), likeMode)
        {
        }
        public LikeFieldFilter(float value, LikeMode likeMode)
            : this(value.ToString(), likeMode)
        {
        }
        public LikeFieldFilter(double value, LikeMode likeMode)
            : this(value.ToString(), likeMode)
        {
        }
        public LikeFieldFilter(decimal value, LikeMode likeMode)
            : this(value.ToString(), likeMode)
        {
        }
        public LikeFieldFilter(IConvertible value, LikeMode likeMode)
            : this(value.ToString(), likeMode)
        {
        }

        internal override string Build(Dictionary<string, object> paramDict)
        {
            string sql = "", vari = "@" + FieldName + "_" + paramDict.Count;
            switch (Mode)
            {
                case LikeMode.AnyWhere:
                    paramDict[vari] = "%" + Value + "%";
                    sql = string.Format("[{0}] LIKE {1}", FieldName, vari);
                    break;
                case LikeMode.End:
                    paramDict[vari] = "%" + Value;
                    sql = string.Format("[{0}] LIKE {1}", FieldName, vari);
                    break;
                case LikeMode.Exact:
                    paramDict[vari] = Value;
                    sql = string.Format("[{0}] = {1}", FieldName, vari);
                    break;
                case LikeMode.Start:
                    paramDict[vari] = Value + "%";
                    sql = string.Format("[{0}] LIKE {1}", FieldName, vari);
                    break;
                case LikeMode.EmptyOrNull:
                    sql = string.Format("([{0}] IS NULL OR [{0}] ='')", FieldName, vari);
                    break;
                case LikeMode.NotAnyWhere:
                    paramDict[vari] = "%" + Value + "%";
                    sql = string.Format("[{0}] NOT LIKE {1}", FieldName, vari);
                    break;
                case LikeMode.NotEnd:
                    paramDict[vari] = "%" + Value;
                    sql = string.Format("[{0}] NOT LIKE {1}", FieldName, vari);
                    break;
                case LikeMode.NotExact:
                    paramDict[vari] = Value;
                    sql = string.Format("[{0}] != {1}", FieldName, vari);
                    break;
                case LikeMode.NotStart:
                    paramDict[vari] = Value + "%";
                    sql = string.Format("[{0}] NOT LIKE {1}", FieldName, vari);
                    break;
                case LikeMode.NotNullAndNotEmpty:
                    sql = string.Format("[{0}] IS NOT NULL AND [{0}] !=''", FieldName, vari);
                    break;
                case LikeMode.FullText:
                    paramDict[vari] = Value;
                    sql = string.Format("CONTAINS([{0}],{1})", FieldName, vari);
                    break;
            }

            return sql;
        }

        public static explicit operator string(LikeFieldFilter value)
        {
            return value.Value;
        }
        public static implicit operator LikeFieldFilter(string value)
        {
            return new LikeFieldFilter(value);
        }
        public static implicit operator LikeFieldFilter(char value)
        {
            return new LikeFieldFilter(value);
        }
        public static implicit operator LikeFieldFilter(int value)
        {
            return new LikeFieldFilter(value);
        }
        public static implicit operator LikeFieldFilter(long value)
        {
            return new LikeFieldFilter(value);
        }
        public static implicit operator LikeFieldFilter(float value)
        {
            return new LikeFieldFilter(value);
        }
        public static implicit operator LikeFieldFilter(decimal value)
        {
            return new LikeFieldFilter(value);
        }
        public static implicit operator LikeFieldFilter(double value)
        {
            return new LikeFieldFilter(value);
        }
        public static implicit operator LikeFieldFilter(SortPart value)
        {
            return new LikeFieldFilter() { Sort = value };
        }
    }
}
