/******************************************
* 模块名称：实体 订单GC支付对应关系
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
	/// 实体 订单GC支付对应关系
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_gc_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单GC支付对应关系
        /// </summary>
        public order_gc_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private string _returnmessage = null;
        private Int32 _step = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
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
        /// 主订单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// GC返回信息
        /// </summary>
        public string ReturnMessage
        {
            set{ _returnmessage=value;}
            get{return _returnmessage;}
        }
        /// <summary>
        /// GC处理步骤（或环节）
        /// </summary>
        public Int32 Step
        {
            set{ _step=value;}
            get{return _step;}
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
