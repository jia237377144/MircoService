using EF.Console.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.EFDemo
{
    class ShopifyContext : DbContext
    {
        public ShopifyContext() : base("ShopifyModel")
        {
            base.Configuration.LazyLoadingEnabled = false;

            //利用参数查询时，会生成对于的where条件，利用此属性可以不生成
            //https://www.cnblogs.com/CreateMyself/p/8989983.html
            base.Configuration.UseDatabaseNullSemantics = true;
        }
        #region Coupon 

        public DbSet<CouponCode> CouponCode { get; set; }
        public DbSet<CouponStatistics> CouponStatistics { get; set; }
        public DbSet<CouponTheme> CouponTheme { get; set; }
        #endregion

        public DbSet<Shop> Shop { get; set; }
    }
}
