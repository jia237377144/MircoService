using EF.Console.DapperFilter;
using EF.Console.DapperFilter.SpecificFieldFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilterTest
{
    public class TB_ProductList_Filter : Filterable<TB_ProductList>
    {
        public IdFieldFilter<int> ID { get; set; }

        public IdFieldFilter<int> SPUID { get; set; }
        public LikeFieldFilter Title { get; set; }

        public RangeFieldFilter<DateTime> AddDate { get; set; }

        public AnyFieldFilter<int> PmsCategoryID { get; set; }

        public CompareFieldFilter<decimal> Price { get; set; }

    }
}
