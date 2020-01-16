/******************************************
* 模块名称：实体 用户基本信息表(user_info表的补充表)
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
	/// 实体 用户基本信息表(user_info表的补充表)
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_info_extend
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户基本信息表(user_info表的补充表)
        /// </summary>
        public user_info_extend(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
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
        private Int32 _waist = Int32.MinValue;
        private string _waistunit = null;
        private Int32 _hip = Int32.MinValue;
        private string _hipunit = null;
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
        private Int32 _isauthmessage = Int32.MinValue;
        private DateTime _authmessagetime = DateTime.MinValue;
        private Int32 _issigninremind = Int32.MinValue;
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
        /// 腰围
        /// </summary>
        public Int32 Waist
        {
            set{ _waist=value;}
            get{return _waist;}
        }
        /// <summary>
        /// 腰围单位CM,INCH
        /// </summary>
        public string WaistUnit
        {
            set{ _waistunit=value;}
            get{return _waistunit;}
        }
        /// <summary>
        /// 臀围
        /// </summary>
        public Int32 Hip
        {
            set{ _hip=value;}
            get{return _hip;}
        }
        /// <summary>
        /// 臀围单位CM,INCH
        /// </summary>
        public string HipUnit
        {
            set{ _hipunit=value;}
            get{return _hipunit;}
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
        /// <summary>
        /// 是否授权短信通知
        /// </summary>
        public Int32 IsAuthMessage
        {
            set{ _isauthmessage=value;}
            get{return _isauthmessage;}
        }
        /// <summary>
        /// 授权短信通知时间
        /// </summary>
        public DateTime AuthMessageTime
        {
            set{ _authmessagetime=value;}
            get{return _authmessagetime;}
        }
        /// <summary>
        /// 是否开启签到提醒
        /// </summary>
        public Int32 IsSigninRemind
        {
            set{ _issigninremind=value;}
            get{return _issigninremind;}
        }
        #endregion
	}
}
