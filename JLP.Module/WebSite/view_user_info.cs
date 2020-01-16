/******************************************
* 模块名称：实体 VIEW
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
	/// 实体 VIEW
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class view_user_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_user_info(){}
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
        private string _firstname = null;
        private string _lastname = null;
        private Int32 _sex = Int32.MinValue;
        private Int32 _jobtype = Int32.MinValue;
        private DateTime _birthday = DateTime.MinValue;
        private decimal _height = decimal.MinValue;
        private string _heightunit = null;
        private decimal _weight = decimal.MinValue;
        private string _weightunit = null;
        private Int32 _bust = Int32.MinValue;
        private string _bustunit = null;
        private string _dailysize = null;
        private string _headimage = null;
        private string _gdprapptoken = null;
        private string _gdprappadid = null;
        private Int32 _invitesendtimes = Int32.MinValue;
        private Int32 _inviteuserid = Int32.MinValue;
        private DateTime _useinvitecodedatetime = DateTime.MinValue;
        private string _invitecode = null;
        private DateTime _generateinvitecodedatetime = DateTime.MinValue;
        private string _generateinvitecodedeviceid = null;
        private string _useinvitecodedeviceid = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// ID(NOT NULL)
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
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName
        {
            set{ _firstname=value;}
            get{return _firstname;}
        }
        /// <summary>
        /// FirstName
        /// </summary>
        public string LastName
        {
            set{ _lastname=value;}
            get{return _lastname;}
        }
        /// <summary>
        /// 性别枚举类型：（男：0，女：1）
        /// </summary>
        public Int32 Sex
        {
            set{ _sex=value;}
            get{return _sex;}
        }
        /// <summary>
        /// 职业类型枚举类型：(Teacher：0，Junior：1，Doctor：2，Engineer：3，Office Lady：4，Others：5)
        /// </summary>
        public Int32 JobType
        {
            set{ _jobtype=value;}
            get{return _jobtype;}
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDay
        {
            set{ _birthday=value;}
            get{return _birthday;}
        }
        /// <summary>
        /// 身高
        /// </summary>
        public decimal Height
        {
            set{ _height=value;}
            get{return _height;}
        }
        /// <summary>
        /// 身高单位CM,INCH
        /// </summary>
        public string HeightUnit
        {
            set{ _heightunit=value;}
            get{return _heightunit;}
        }
        /// <summary>
        /// 体重
        /// </summary>
        public decimal Weight
        {
            set{ _weight=value;}
            get{return _weight;}
        }
        /// <summary>
        /// 体重单位KG,Lbs
        /// </summary>
        public string WeightUnit
        {
            set{ _weightunit=value;}
            get{return _weightunit;}
        }
        /// <summary>
        /// 胸围
        /// </summary>
        public Int32 Bust
        {
            set{ _bust=value;}
            get{return _bust;}
        }
        /// <summary>
        /// 胸围单位CM,INCH
        /// </summary>
        public string BustUnit
        {
            set{ _bustunit=value;}
            get{return _bustunit;}
        }
        /// <summary>
        /// M,L,XL,XXL,3XL
        /// </summary>
        public string DailySize
        {
            set{ _dailysize=value;}
            get{return _dailysize;}
        }
        /// <summary>
        /// 头像
        /// </summary>
        public string HeadImage
        {
            set{ _headimage=value;}
            get{return _headimage;}
        }
        /// <summary>
        /// Adjust控制面板中的应用识别码(退出第三方登录使用)
        /// </summary>
        public string GdprAppToken
        {
            set{ _gdprapptoken=value;}
            get{return _gdprapptoken;}
        }
        /// <summary>
        /// Adjust设备标识符(退出第三方登录使用)
        /// </summary>
        public string GdprAppAdid
        {
            set{ _gdprappadid=value;}
            get{return _gdprappadid;}
        }
        /// <summary>
        /// 我作为邀请人发出的邀请次数
        /// </summary>
        public Int32 InviteSendTimes
        {
            set{ _invitesendtimes=value;}
            get{return _invitesendtimes;}
        }
        /// <summary>
        /// 我作为注册人是谁邀请我来注册的邀请人的UserID
        /// </summary>
        public Int32 InviteUserID
        {
            set{ _inviteuserid=value;}
            get{return _inviteuserid;}
        }
        /// <summary>
        /// 我作为注册人注册时使用邀请码的日期
        /// </summary>
        public DateTime UseInviteCodeDateTime
        {
            set{ _useinvitecodedatetime=value;}
            get{return _useinvitecodedatetime;}
        }
        /// <summary>
        /// 邀请码
        /// </summary>
        public string InviteCode
        {
            set{ _invitecode=value;}
            get{return _invitecode;}
        }
        /// <summary>
        /// 产生邀请码的日期
        /// </summary>
        public DateTime GenerateInviteCodeDateTime
        {
            set{ _generateinvitecodedatetime=value;}
            get{return _generateinvitecodedatetime;}
        }
        /// <summary>
        /// 产生邀请码的设备ID
        /// </summary>
        public string GenerateInviteCodeDeviceID
        {
            set{ _generateinvitecodedeviceid=value;}
            get{return _generateinvitecodedeviceid;}
        }
        /// <summary>
        /// 使用邀请码的设备ID
        /// </summary>
        public string UseInviteCodeDeviceID
        {
            set{ _useinvitecodedeviceid=value;}
            get{return _useinvitecodedeviceid;}
        }
        #endregion
	}
}
