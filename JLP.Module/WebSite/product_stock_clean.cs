/******************************************
* 模块名称：实体 产品库存清理表
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
	/// 实体 产品库存清理表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_stock_clean
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品库存清理表
        /// </summary>
        public product_stock_clean(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _orderdetailid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _lockcount = Int32.MinValue;
        private DateTime _intotime = DateTime.MinValue;
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
        /// 主订单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 子订单ID，外键ID
        /// </summary>
        public Int32 OrderDetailID
        {
            set{ _orderdetailid=value;}
            get{return _orderdetailid;}
        }
        /// <summary>
        /// PID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 库存锁定量(生成订单数量加N,支付成功数量减N)
        /// </summary>
        public Int32 LockCount
        {
            set{ _lockcount=value;}
            get{return _lockcount;}
        }
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime IntoTime
        {
            set{ _intotime=value;}
            get{return _intotime;}
        }
        #endregion
	}
}
