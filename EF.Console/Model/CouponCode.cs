using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.Model
{
    /// <summary>
    /// ShareCoupon 优惠券
    /// </summary>
    public class CouponCode
    {
        /// <summary>
        ///主键
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        ///店铺ID
        /// </summary>
        public int ShopID
        {
            get; set;
        }

        /// <summary>
        ///店铺名称
        /// </summary>
        public string ShopName
        {
            get; set;
        }

        /// <summary>
        ///优惠券名称
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        ///优惠券描述
        /// </summary>
        public string Message
        {
            get; set;
        }

        /// <summary>
        ///优惠券码
        /// </summary>
        public string Code
        {
            get; set;
        }

        /// <summary>
        ///优惠码类型（枚举：0、不限制;1、按次数显示;2、按时间显示）
        /// </summary>
        public int? CodeType
        {
            get; set;
        }

        /// <summary>
        ///优惠码展示次数
        /// </summary>
        public int ShowCount
        {
            get; set;
        }

        /// <summary>
        ///开始时间（控制优惠码展示时间段，超过时间段不展示，但是还有可能能够使用）
        /// </summary>
        public System.DateTime BeginTime
        {
            get; set;
        } = new DateTime(1900, 1, 1);

        /// <summary>
        ///结束时间
        /// </summary>
        public System.DateTime EndTime
        {
            get; set;
        } = new DateTime(1900, 1, 1);

        /// <summary>
        ///主题ID
        /// </summary>
        public int ThemeID
        {
            get; set;
        }

        /// <summary>
        ///Logo图片
        /// </summary>
        public string LogoImage
        {
            get; set;
        }

        public int LogoImageWidth
        {
            get; set;
        }
        public int LogoImageHeight
        {
            get; set;
        }


        /// <summary>
        ///背景图片
        /// </summary>
        public string BackgroundImage
        {
            get; set;
        }

        public int BackgroundImageWidth { get; set; }

        public int BackgroundImageHeight { get; set; }

        /// <summary>
        ///字体
        /// </summary>
        public string Font
        {
            get; set;
        }

        /// <summary>
        ///优惠券描述的字体颜色
        /// </summary>
        public string MessageColor
        {
            get; set;
        }

        /// <summary>
        ///优惠券背景色
        /// </summary>
        public string BackgroundColor
        {
            get; set;
        }

        /// <summary>
        ///优惠码颜色
        /// </summary>
        public string CodeColor
        {
            get; set;
        }

        /// <summary>
        ///优惠码背景颜色
        /// </summary>
        public string CodeBackgroundColor
        {
            get; set;
        }

        /// <summary>
        ///优惠券描述字体大小
        /// </summary>
        public int? MessageFontSize
        {
            get; set;
        }

        /// <summary>
        ///购物车没产品是否显示
        /// </summary>
        public int? NoItemIsDisplay
        {
            get; set;
        }

        /// <summary>
        ///用户离开的时候显示
        /// </summary>
        public int? ShowWhenLeave
        {
            get; set;
        }

        /// <summary>
        ///每个用户只显示一次
        /// </summary>
        public int? ShowOnlyOnceVisitor
        {
            get; set;
        }

        /// <summary>
        ///是否显示优惠券横条
        /// </summary>
        public int? ShowCodeBar
        {
            get; set;
        }

        /// <summary>
        ///是否启用
        /// </summary>
        public int? Enable
        {
            get; set;
        }

        /// <summary>
        ///是否删除
        /// </summary>
        public int? IsDelete
        {
            get; set;
        }

        /// <summary>
        ///
        /// </summary>
        public System.DateTime AddTime
        {
            get; set;
        } = new DateTime(1900, 1, 1);

        /// <summary>
        ///
        /// </summary>
        public System.DateTime UpdateTime
        {
            get; set;
        } = new DateTime(1900, 1, 1);


    }
}
