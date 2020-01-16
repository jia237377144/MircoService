/******************************************
* 模块名称：实体 订单跟踪信息表
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
	/// 实体 订单跟踪信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_track_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单跟踪信息表
        /// </summary>
        public order_track_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _orderdetailid = Int32.MinValue;
        private string _cnmessage = null;
        private string _cuturemessage = null;
        private string _expressno = null;
        private DateTime _intotracktime = DateTime.MinValue;
        private Int32 _createuserid = Int32.MinValue;
        private string _createuseremail = null;
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
        /// 子单ID，外键ID
        /// </summary>
        public Int32 OrderDetailID
        {
            set{ _orderdetailid=value;}
            get{return _orderdetailid;}
        }
        /// <summary>
        /// 中文描述
        /// </summary>
        public string CNMessage
        {
            set{ _cnmessage=value;}
            get{return _cnmessage;}
        }
        /// <summary>
        /// 外语描述
        /// </summary>
        public string CutureMessage
        {
            set{ _cuturemessage=value;}
            get{return _cuturemessage;}
        }
        /// <summary>
        /// 快递运单编号
        /// </summary>
        public string ExpressNo
        {
            set{ _expressno=value;}
            get{return _expressno;}
        }
        /// <summary>
        /// 创建跟踪的时间
        /// </summary>
        public DateTime InToTrackTime
        {
            set{ _intotracktime=value;}
            get{return _intotracktime;}
        }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public Int32 CreateUserID
        {
            set{ _createuserid=value;}
            get{return _createuserid;}
        }
        /// <summary>
        /// 创建人邮箱名称
        /// </summary>
        public string CreateUserEmail
        {
            set{ _createuseremail=value;}
            get{return _createuseremail;}
        }
        #endregion
	}
}
