/******************************************
* 模块名称：实体 订单退税表
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
	/// 实体 订单退税表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_tax_return
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单退税表
        /// </summary>
        public order_tax_return(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private string _taxno = null;
        private string _imagepath = null;
        private decimal _returnmoney = decimal.MinValue;
        private string _currencyname = null;
        private DateTime _adddate = DateTime.MinValue;
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
        /// 订单主单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 税号
        /// </summary>
        public string TaxNO
        {
            set{ _taxno=value;}
            get{return _taxno;}
        }
        /// <summary>
        /// 上传的图片路径
        /// </summary>
        public string ImagePath
        {
            set{ _imagepath=value;}
            get{return _imagepath;}
        }
        /// <summary>
        /// 退还的金额
        /// </summary>
        public decimal ReturnMoney
        {
            set{ _returnmoney=value;}
            get{return _returnmoney;}
        }
        /// <summary>
        /// 币种符号
        /// </summary>
        public string CurrencyName
        {
            set{ _currencyname=value;}
            get{return _currencyname;}
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
