/******************************************
* 模块名称：实体 系统APP消息模板
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
	/// 实体 系统APP消息模板
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_app_msg_template
	{
        #region 构造函数
        /// <summary>
        /// 实体 系统APP消息模板
        /// </summary>
        public user_app_msg_template(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _typeid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _title = null;
        private string _body = null;
        private string _mobileurl = null;
        private string _soundfilename = null;
        private Int32 _expirevalue = Int32.MinValue;
        private Int32 _expireunit = Int32.MinValue;
        private DateTime _expiretime = DateTime.MinValue;
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
        /// 消息模板的类型，枚举类型EPushSetting
        /// </summary>
        public Int32 TypeID
        {
            set{ _typeid=value;}
            get{return _typeid;}
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
        /// 消息模板的标题，可以包含占位符
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 消息模板的内容，可以包含占位符
        /// </summary>
        public string Body
        {
            set{ _body=value;}
            get{return _body;}
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
