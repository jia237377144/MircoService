/******************************************
* 模块名称：实体 order_sync_log
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
	/// 实体 order_sync_log
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_sync_log
	{
        #region 构造函数
        /// <summary>
        /// 实体 order_sync_log
        /// </summary>
        public order_sync_log(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _ordertype = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private DateTime _paytime = DateTime.MinValue;
        private string _errormessage = null;
        private DateTime _errortime = DateTime.MinValue;
        private string _handleuser = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 主单ID或者子单ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 订单类型【0:主单，1：子单】
        /// </summary>
        public Int32 OrderType
        {
            set{ _ordertype=value;}
            get{return _ordertype;}
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
        /// 多语言ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 品类ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime PayTime
        {
            set{ _paytime=value;}
            get{return _paytime;}
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage
        {
            set{ _errormessage=value;}
            get{return _errormessage;}
        }
        /// <summary>
        /// 出错时间
        /// </summary>
        public DateTime ErrorTime
        {
            set{ _errortime=value;}
            get{return _errortime;}
        }
        /// <summary>
        /// 处理人
        /// </summary>
        public string HandleUser
        {
            set{ _handleuser=value;}
            get{return _handleuser;}
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
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        #endregion
	}
}
