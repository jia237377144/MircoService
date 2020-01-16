using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter
{
    /// <summary>
    /// 分页
    /// </summary>
    [Serializable]
    public class Pager
    {
        private int pageIndex = 1;
        private int pageSize = 20;
        public int PageIndex
        {
            get
            {
                return this.pageIndex;
            }
            set
            {
                if (value > 0)
                    this.pageIndex = value;
            }
        }
        public int PageSize
        {
            get
            {
                return this.pageSize;
            }
            set
            {
                if (value > 0)
                    this.pageSize = value;
            }
        }

        public static readonly Pager Default = new Pager();
        public static readonly Pager Max = new Pager { pageSize = int.MaxValue };
        public static readonly Pager Min = new Pager { pageSize = 1 };

        public Pager() { }

        public Pager(int pageIndex, int PageSize)
        {
            this.PageIndex = pageIndex;
            this.PageSize = PageSize;
        }

        public override string ToString()
        {
            return $"{{PageIndex:{this.PageIndex},PageSize:{this.PageSize}}}";
        }

    }
}
