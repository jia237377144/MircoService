/******************************************
* 模块名称：实体 用户设备优惠券关系表
* 当前版本：1.0
* 开发人员：tidebuy
* 生成时间：2019/9/3
* 版本历史：此代码由 VB/C#.Net实体代码生成工具(EntitysCodeGenerate 4.8) 自动生成。
* 
******************************************/
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace JLP.Module.WebSite
{
	/// <summary>
	/// 实体 用户设备优惠券关系表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_app_coupon_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户设备优惠券关系表
        /// </summary>
        public user_app_coupon_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _deviceid = null;
        private Int32 _devicetype = Int32.MinValue;
        private Int32 _contentid = Int32.MinValue;
        private Int32 _couponid = Int32.MinValue;
        private Int32 _coupontype = Int32.MinValue;
        private Int32 _orderpushtype = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 用户ID，外键ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceID
        {
            set{ _deviceid=value;}
            get{return _deviceid;}
        }
        /// <summary>
        /// 设备类型 枚举EDevicePlatform
        /// </summary>
        public Int32 DeviceType
        {
            set{ _devicetype=value;}
            get{return _devicetype;}
        }
        /// <summary>
        /// 内容ID，外键ID
        /// </summary>
        public Int32 ContentID
        {
            set{ _contentid=value;}
            get{return _contentid;}
        }
        /// <summary>
        /// 优惠码ID，外键ID
        /// </summary>
        public Int32 CouponID
        {
            set{ _couponid=value;}
            get{return _couponid;}
        }
        /// <summary>
        /// 人工或系统优惠码类型枚举
        /// </summary>
        public Int32 CouponType
        {
            set{ _coupontype=value;}
            get{return _coupontype;}
        }
        /// <summary>
        /// 促销推送类型 EOrderPushType
        /// </summary>
        public Int32 OrderPushType
        {
            set{ _orderpushtype=value;}
            get{return _orderpushtype;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        #endregion
	}
}
