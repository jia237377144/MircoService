/******************************************
* 模块名称：实体 订单投诉信息
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
	/// 实体 订单投诉信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_message_disbute
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单投诉信息
        /// </summary>
        public user_message_disbute(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _message = null;
        private string _attachurl = null;
        private DateTime _addtime = DateTime.MinValue;
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
        /// 订单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 留言内容
        /// </summary>
        public string Message
        {
            set{ _message=value;}
            get{return _message;}
        }
        /// <summary>
        /// 附件地址
        /// </summary>
        public string AttachURL
        {
            set{ _attachurl=value;}
            get{return _attachurl;}
        }
        /// <summary>
        /// 添加留言时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        #endregion
	}
}
