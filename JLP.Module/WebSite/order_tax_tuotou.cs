/******************************************
* 模块名称：实体 订单妥投信息表
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
	/// 实体 订单妥投信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_tax_tuotou
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单妥投信息表
        /// </summary>
        public order_tax_tuotou(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _type = Int32.MinValue;
        private decimal _usdprice = decimal.MinValue;
        private decimal _currentprice = decimal.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
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
        /// 订单主单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 险种类型枚举
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 妥投险金额(美金价格)
        /// </summary>
        public decimal USDPrice
        {
            set{ _usdprice=value;}
            get{return _usdprice;}
        }
        /// <summary>
        /// 下单时币种价格(可能为多币种或美金)
        /// </summary>
        public decimal CurrentPrice
        {
            set{ _currentprice=value;}
            get{return _currentprice;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        #endregion
	}
}
