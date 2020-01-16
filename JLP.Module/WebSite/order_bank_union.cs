/******************************************
* 模块名称：实体 记录用户输入的银联信息
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
	/// 实体 记录用户输入的银联信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_bank_union
	{
        #region 构造函数
        /// <summary>
        /// 实体 记录用户输入的银联信息
        /// </summary>
        public order_bank_union(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private string _fullname = null;
        private decimal _recordprice = decimal.MinValue;
        private DateTime _recorddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 主单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 用户FullName
        /// </summary>
        public string FullName
        {
            set{ _fullname=value;}
            get{return _fullname;}
        }
        /// <summary>
        /// 用户交易记录价格
        /// </summary>
        public decimal RecordPrice
        {
            set{ _recordprice=value;}
            get{return _recordprice;}
        }
        /// <summary>
        /// 用户交易记录时间
        /// </summary>
        public DateTime RecordDate
        {
            set{ _recorddate=value;}
            get{return _recorddate;}
        }
        #endregion
	}
}
