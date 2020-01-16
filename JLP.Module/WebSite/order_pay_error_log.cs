/******************************************
* 模块名称：实体 订单付款错误日志信息
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
	/// 实体 订单付款错误日志信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_pay_error_log
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单付款错误日志信息
        /// </summary>
        public order_pay_error_log(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _errorcode = null;
        private Int32 _paytype = Int32.MinValue;
        private Int32 _paylogid = Int32.MinValue;
        private Int32 _issms = Int32.MinValue;
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
        /// 日志错误码
        /// </summary>
        public string ErrorCode
        {
            set{ _errorcode=value;}
            get{return _errorcode;}
        }
        /// <summary>
        /// 支付方式枚举(Paypal,GC,WorldPay,Adyen,OceanPay,AliPay)
        /// </summary>
        public Int32 PayType
        {
            set{ _paytype=value;}
            get{return _paytype;}
        }
        /// <summary>
        /// 支付方式日志信息表ID，外键ID
        /// </summary>
        public Int32 PayLogID
        {
            set{ _paylogid=value;}
            get{return _paylogid;}
        }
        /// <summary>
        /// 是否需要发送短信通知
        /// </summary>
        public Int32 IsSMS
        {
            set{ _issms=value;}
            get{return _issms;}
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
