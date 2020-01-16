using System;
using System.ComponentModel.DataAnnotations;

namespace EF.Console.Model
{
    /// <summary>
    /// ShareCoupon 优惠券展示主题
    /// </summary>
    public class CouponTheme
    {
        /// <summary>
        ///主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        ///字体
        /// </summary>
        public string Font { get; set; }

        /// <summary>
        ///优惠券描述的颜色
        /// </summary>
        public string MessageColor { get; set; }

        /// <summary>
        ///优惠券背景色
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///是否启用
        /// </summary>
        public int Enable { get; set; }

        /// <summary>
        ///是否删除
        /// </summary>
        public int IsDelete { get; set; }

        /// <summary>
        ///
        /// </summary>
        public System.DateTime AddTime { get; set; } = new DateTime(1900, 1, 1);

        /// <summary>
        ///
        /// </summary>
        public System.DateTime UpdateTime { get; set; } = new DateTime(1900, 1, 1);


    }
}
