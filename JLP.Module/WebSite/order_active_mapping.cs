/******************************************
* 模块名称：实体 订单和活动关系表
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
	/// 实体 订单和活动关系表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_active_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单和活动关系表
        /// </summary>
        public order_active_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _orderdetailid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _activepriceformulaid = Int32.MinValue;
        private Int32 _activelistid = Int32.MinValue;
        private Int32 _activedetailsid = Int32.MinValue;
        private DateTime _intoordertime = DateTime.MinValue;
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
        /// 主单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 子单ID，外键ID
        /// </summary>
        public Int32 OrderDetailID
        {
            set{ _orderdetailid=value;}
            get{return _orderdetailid;}
        }
        /// <summary>
        /// SKUID，外键ID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// SKU批量调整活动价格ID，外键ID
        /// </summary>
        public Int32 ActivePriceFormulaID
        {
            set{ _activepriceformulaid=value;}
            get{return _activepriceformulaid;}
        }
        /// <summary>
        /// 活动列表ID，外键ID
        /// </summary>
        public Int32 ActiveListID
        {
            set{ _activelistid=value;}
            get{return _activelistid;}
        }
        /// <summary>
        /// 活动列表明细ID，外键ID
        /// </summary>
        public Int32 ActiveDetailsID
        {
            set{ _activedetailsid=value;}
            get{return _activedetailsid;}
        }
        /// <summary>
        /// 加入订单的时间
        /// </summary>
        public DateTime InToOrderTime
        {
            set{ _intoordertime=value;}
            get{return _intoordertime;}
        }
        #endregion
	}
}
