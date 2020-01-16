using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter
{
    public sealed class SortPart
    {
        internal int Priority { get; set; }

        public SortPart(int value)
        {
            this.Priority = value;
        }

        /// <summary>
        /// 把int类型，隐式转换为SortPart
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator SortPart(int value)
        {
            return new SortPart(value);
        }

        /// <summary>
        /// 把SortPart类型隐式转换为int
        /// </summary>
        /// <param name="sortPart"></param>
        public static implicit operator int(SortPart sortPart)
        {
            return sortPart.Priority;
        }


        public override string ToString()
        {
            if (this.Priority == 0)
            {
                return "不排序";
            }
            else
            {
                if (this.Priority > 0)
                {
                    return $"正序：第{this.Priority}排序字段";
                }
                else
                {
                    return $"倒序：第{-this.Priority}排序字段";
                }
            }
        }


    }
}
