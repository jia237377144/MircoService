/******************************************
* 模块名称：实体 SKU批量调整售卖价格明细表
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
	/// 实体 SKU批量调整售卖价格明细表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku_sellpriceformula_detail
	{
        #region 构造函数
        /// <summary>
        /// 实体 SKU批量调整售卖价格明细表
        /// </summary>
        public product_sku_sellpriceformula_detail(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _masterid = Int32.MinValue;
        private decimal _pricebegin = decimal.MinValue;
        private decimal _priceend = decimal.MinValue;
        private Int32 _pricecondition = Int32.MinValue;
        private DateTime _uptimebegin = DateTime.MinValue;
        private DateTime _uptimeend = DateTime.MinValue;
        private Int32 _uptimecondition = Int32.MinValue;
        private string _formula = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键、自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SKU批量调整售卖价格主表ID，外键ID
        /// </summary>
        public Int32 MasterID
        {
            set{ _masterid=value;}
            get{return _masterid;}
        }
        /// <summary>
        /// 开始价格
        /// </summary>
        public decimal PriceBegin
        {
            set{ _pricebegin=value;}
            get{return _pricebegin;}
        }
        /// <summary>
        /// 结束价格
        /// </summary>
        public decimal PriceEnd
        {
            set{ _priceend=value;}
            get{return _priceend;}
        }
        /// <summary>
        /// 价格条件，And、Or
        /// </summary>
        public Int32 PriceCondition
        {
            set{ _pricecondition=value;}
            get{return _pricecondition;}
        }
        /// <summary>
        /// 上架开始时间
        /// </summary>
        public DateTime UpTimeBegin
        {
            set{ _uptimebegin=value;}
            get{return _uptimebegin;}
        }
        /// <summary>
        /// 上架结束时间
        /// </summary>
        public DateTime UpTimeEnd
        {
            set{ _uptimeend=value;}
            get{return _uptimeend;}
        }
        /// <summary>
        /// 上架时间条件，And、Or
        /// </summary>
        public Int32 UpTimeCondition
        {
            set{ _uptimecondition=value;}
            get{return _uptimecondition;}
        }
        /// <summary>
        /// 调整价格的公式
        /// </summary>
        public string Formula
        {
            set{ _formula=value;}
            get{return _formula;}
        }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// CreateUserName
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
