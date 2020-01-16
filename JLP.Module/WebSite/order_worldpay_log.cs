/******************************************
* 模块名称：实体 用户生成订单使用WorldPay方式支付之后记录WorldPay日志
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
	/// 实体 用户生成订单使用WorldPay方式支付之后记录WorldPay日志
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_worldpay_log
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户生成订单使用WorldPay方式支付之后记录WorldPay日志
        /// </summary>
        public order_worldpay_log(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private string _content = null;
        private DateTime _adddate = DateTime.MinValue;
        private string _userip = null;
        private Int32 _status = Int32.MinValue;
        private string _errorcode = null;
        private string _errormessage = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID,自增ID(NOT NULL)
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
        /// WorldPay记录内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// WorldPay记录插入时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        /// <summary>
        /// 用户IP
        /// </summary>
        public string UserIP
        {
            set{ _userip=value;}
            get{return _userip;}
        }
        /// <summary>
        /// 状态枚举
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 错误码
        /// </summary>
        public string ErrorCode
        {
            set{ _errorcode=value;}
            get{return _errorcode;}
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage
        {
            set{ _errormessage=value;}
            get{return _errormessage;}
        }
        #endregion
	}
}
