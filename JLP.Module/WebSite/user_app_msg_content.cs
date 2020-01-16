﻿/******************************************
* 模块名称：实体 消息记录表 包含手动消息和系统消息
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
	/// 实体 消息记录表 包含手动消息和系统消息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_app_msg_content
	{
        #region 构造函数
        /// <summary>
        /// 实体 消息记录表 包含手动消息和系统消息
        /// </summary>
        public user_app_msg_content(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _msgcategoryid = Int32.MinValue;
        private string _title = null;
        private Int32 _msgtype = Int32.MinValue;
        private Int32 _msgtemplateid = Int32.MinValue;
        private string _content = null;
        private string _mobileurl = null;
        private Int32 _targetcount = Int32.MinValue;
        private string _targetjson = null;
        private string _devicetypejson = null;
        private DateTime _msgsendtime = DateTime.MinValue;
        private string _soundfilename = null;
        private Int32 _expirevalue = Int32.MinValue;
        private Int32 _expireunit = Int32.MinValue;
        private DateTime _expiretime = DateTime.MinValue;
        private Int32 _msgstatus = Int32.MinValue;
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
        /// 手动消息类型表，外键ID；对于系统消息，则存储活动ID
        /// </summary>
        public Int32 MsgCategoryID
        {
            set{ _msgcategoryid=value;}
            get{return _msgcategoryid;}
        }
        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 消息类型，枚举：系统还是手动
        /// </summary>
        public Int32 MsgType
        {
            set{ _msgtype=value;}
            get{return _msgtype;}
        }
        /// <summary>
        /// MsgTemplateID
        /// </summary>
        public Int32 MsgTemplateID
        {
            set{ _msgtemplateid=value;}
            get{return _msgtemplateid;}
        }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// 在M端的目标URL
        /// </summary>
        public string MobileURL
        {
            set{ _mobileurl=value;}
            get{return _mobileurl;}
        }
        /// <summary>
        /// 当前这条消息要发送的目标总人数
        /// </summary>
        public Int32 TargetCount
        {
            set{ _targetcount=value;}
            get{return _targetcount;}
        }
        /// <summary>
        /// 群发对象JSON
        /// </summary>
        public string TargetJSON
        {
            set{ _targetjson=value;}
            get{return _targetjson;}
        }
        /// <summary>
        /// 发送给哪个设备类型JSON
        /// </summary>
        public string DeviceTypeJSON
        {
            set{ _devicetypejson=value;}
            get{return _devicetypejson;}
        }
        /// <summary>
        /// 定时发送时间
        /// </summary>
        public DateTime MsgSendTime
        {
            set{ _msgsendtime=value;}
            get{return _msgsendtime;}
        }
        /// <summary>
        /// 手机里面的声音文件名称
        /// </summary>
        public string SoundFileName
        {
            set{ _soundfilename=value;}
            get{return _soundfilename;}
        }
        /// <summary>
        /// 相对过期时间值
        /// </summary>
        public Int32 ExpireValue
        {
            set{ _expirevalue=value;}
            get{return _expirevalue;}
        }
        /// <summary>
        /// 相对过期时间单位枚举：1=分钟，2=小时，3=天，4=周，5=月，6=季，7=年
        /// </summary>
        public Int32 ExpireUnit
        {
            set{ _expireunit=value;}
            get{return _expireunit;}
        }
        /// <summary>
        /// 绝对过期时间点
        /// </summary>
        public DateTime ExpireTime
        {
            set{ _expiretime=value;}
            get{return _expiretime;}
        }
        /// <summary>
        /// 消息状态枚举，0=无效，1=有效，2=已发送
        /// </summary>
        public Int32 MsgStatus
        {
            set{ _msgstatus=value;}
            get{return _msgstatus;}
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
