/******************************************
* 模块名称：实体 网站注册用户信息表
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
	/// 实体 网站注册用户信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 网站注册用户信息表
        /// </summary>
        public user_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _email = null;
        private string _password = null;
        private DateTime _regdate = DateTime.MinValue;
        private string _regip = null;
        private Int32 _regtype = Int32.MinValue;
        private DateTime _lastlogindate = DateTime.MinValue;
        private string _lastloginip = null;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _userlevel = Int32.MinValue;
        private Int32 _platform = Int32.MinValue;
        private DateTime _lastagreetermsdate = DateTime.MinValue;
        private Int32 _isverifyemail = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _userleveltype = Int32.MinValue;
        private DateTime _userlevelstarttime = DateTime.MinValue;
        private DateTime _userlevelendtime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 登录邮箱（等同于登录名称）
        /// </summary>
        public string Email
        {
            set{ _email=value;}
            get{return _email;}
        }
        /// <summary>
        /// 登录密码（MD5加密）
        /// </summary>
        public string Password
        {
            set{ _password=value;}
            get{return _password;}
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegDate
        {
            set{ _regdate=value;}
            get{return _regdate;}
        }
        /// <summary>
        /// 注册IP
        /// </summary>
        public string RegIP
        {
            set{ _regip=value;}
            get{return _regip;}
        }
        /// <summary>
        /// 用户注册类型枚举：（采用之前的枚举，如facebook,twritter）
        /// </summary>
        public Int32 RegType
        {
            set{ _regtype=value;}
            get{return _regtype;}
        }
        /// <summary>
        /// 用户最后登录时间
        /// </summary>
        public DateTime LastLoginDate
        {
            set{ _lastlogindate=value;}
            get{return _lastlogindate;}
        }
        /// <summary>
        /// 用户最后登录IP
        /// </summary>
        public string LastLoginIP
        {
            set{ _lastloginip=value;}
            get{return _lastloginip;}
        }
        /// <summary>
        /// 在哪个语言站注册的
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 用户等级（采用之前的枚举，如：vip1，vip2）
        /// </summary>
        public Int32 UserLevel
        {
            set{ _userlevel=value;}
            get{return _userlevel;}
        }
        /// <summary>
        /// 用户注册平台枚举（网站，M，App）
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
        }
        /// <summary>
        /// 同意最新条款时间
        /// </summary>
        public DateTime LastAgreeTermsDate
        {
            set{ _lastagreetermsdate=value;}
            get{return _lastagreetermsdate;}
        }
        /// <summary>
        /// 是否已验证邮箱(1-已验证，0-未验证)
        /// </summary>
        public Int32 IsVerifyEmail
        {
            set{ _isverifyemail=value;}
            get{return _isverifyemail;}
        }
        /// <summary>
        /// 用户状态枚举（采用之前的枚举，如：启用，禁用，黑名单）
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 会员级别枚举类型(系统、赠送、邀请)
        /// </summary>
        public Int32 UserLevelType
        {
            set{ _userleveltype=value;}
            get{return _userleveltype;}
        }
        /// <summary>
        /// 会员级别有效期的开始时间(不包含包括会员级别枚举类型为系统类型)
        /// </summary>
        public DateTime UserLevelStartTime
        {
            set{ _userlevelstarttime=value;}
            get{return _userlevelstarttime;}
        }
        /// <summary>
        /// 会员级别有效期的结束时间(不包含包括会员级别枚举类型为系统类型))
        /// </summary>
        public DateTime UserLevelEndTime
        {
            set{ _userlevelendtime=value;}
            get{return _userlevelendtime;}
        }
        #endregion
	}
}
