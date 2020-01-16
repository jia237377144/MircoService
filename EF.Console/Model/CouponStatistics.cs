using System;
using System.ComponentModel.DataAnnotations;

namespace EF.Console.Model
{
    /// <summary>
    /// ShareCoupon 优惠券展示数量
    /// </summary>
    public class CouponStatistics
    {
        /// <summary>
        ///主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        ///优惠券ID
        /// </summary>
        public int CouponId { get; set; }

        /// <summary>
        ///显示次数
        /// </summary>
        public int ViewCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        public System.DateTime AddTime { get; set; } = new DateTime(1900, 1, 1);


    }
}
