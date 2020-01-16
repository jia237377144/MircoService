/******************************************
* 模块名称：实体 个人中心站内信
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
	/// 实体 个人中心站内信
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_message_website
	{
        #region 构造函数
        /// <summary>
        /// 实体 个人中心站内信
        /// </summary>
        public user_message_website(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _parentid = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _adminid = Int32.MinValue;
        private string _title = null;
        private string _content = null;
        private Int32 _messagetype = Int32.MinValue;
        private Int32 _messagestatus = Int32.MinValue;
        private string _questiontypejson = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private string _phone = null;
        private string _attachurl = null;
        private Int32 _platform = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private string _createusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
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
        /// 消息父分类ID
        /// </summary>
        public Int32 ParentID
        {
            set{ _parentid=value;}
            get{return _parentid;}
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
        /// 后台管理用户ID
        /// </summary>
        public Int32 AdminID
        {
            set{ _adminid=value;}
            get{return _adminid;}
        }
        /// <summary>
        /// 站内消息标题
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 站内消息内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// 站内消息类型枚举类型（1:用户发送消息、2:系统回复消息）
        /// </summary>
        public Int32 MessageType
        {
            set{ _messagetype=value;}
            get{return _messagetype;}
        }
        /// <summary>
        /// 站内消息状态枚举类型（1:未读、2:已读）
        /// </summary>
        public Int32 MessageStatus
        {
            set{ _messagestatus=value;}
            get{return _messagestatus;}
        }
        /// <summary>
        /// 消息问题类型：[1,2]
        /// </summary>
        public string QuestionTypeJSON
        {
            set{ _questiontypejson=value;}
            get{return _questiontypejson;}
        }
        /// <summary>
        /// 站内消息状态枚举类型（1：有效，2：无效）
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
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
        /// 用户手机号码
        /// </summary>
        public string Phone
        {
            set{ _phone=value;}
            get{return _phone;}
        }
        /// <summary>
        /// 附件URL
        /// </summary>
        public string AttachURL
        {
            set{ _attachurl=value;}
            get{return _attachurl;}
        }
        /// <summary>
        /// 平台ID  PC端 = 1, M端 = 2,APP = 3
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
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
        /// CreateUserName
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
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
