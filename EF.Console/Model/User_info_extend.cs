using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.Model
{
    public class User_info_extend
    {
        #region 常量
        ///<summary>
        ///用户基本信息表(user_info表的补充表)
        ///</summary>
        public const string _USER_INFO_EXTEND_ = "user_info_extend";
        ///<summary>
        ///主键ID，自增ID
        ///</summary>
        public const string _ID_ = "ID";
        ///<summary>
        ///用户ID，外键ID
        ///</summary>
        public const string _USERID_ = "UserID";
        ///<summary>
        ///FirstName
        ///</summary>
        public const string _FIRSTNAME_ = "FirstName";
        ///<summary>
        ///FirstName
        ///</summary>
        public const string _LASTNAME_ = "LastName";
        ///<summary>
        ///性别枚举类型：（男：0，女：1）
        ///</summary>
        public const string _SEX_ = "Sex";
        ///<summary>
        ///职业类型枚举类型：(Teacher：0，Junior：1，Doctor：2，Engineer：3，Office Lady：4，Others：5)
        ///</summary>
        public const string _JOBTYPE_ = "JobType";
        ///<summary>
        ///出生日期
        ///</summary>
        public const string _BIRTHDAY_ = "BirthDay";
        ///<summary>
        ///身高
        ///</summary>
        public const string _HEIGHT_ = "Height";
        ///<summary>
        ///身高单位CM,INCH
        ///</summary>
        public const string _HEIGHTUNIT_ = "HeightUnit";
        ///<summary>
        ///体重
        ///</summary>
        public const string _WEIGHT_ = "Weight";
        ///<summary>
        ///体重单位KG,Lbs
        ///</summary>
        public const string _WEIGHTUNIT_ = "WeightUnit";
        ///<summary>
        ///胸围
        ///</summary>
        public const string _BUST_ = "Bust";
        ///<summary>
        ///胸围单位CM,INCH
        ///</summary>
        public const string _BUSTUNIT_ = "BustUnit";
        ///<summary>
        ///腰围
        ///</summary>
        public const string _WAIST_ = "Waist";
        ///<summary>
        ///腰围单位CM,INCH
        ///</summary>
        public const string _WAISTUNIT_ = "WaistUnit";
        ///<summary>
        ///臀围
        ///</summary>
        public const string _HIP_ = "Hip";
        ///<summary>
        ///臀围单位CM,INCH
        ///</summary>
        public const string _HIPUNIT_ = "HipUnit";
        ///<summary>
        ///M,L,XL,XXL,3XL
        ///</summary>
        public const string _DAILYSIZE_ = "DailySize";
        ///<summary>
        ///头像
        ///</summary>
        public const string _HEADIMAGE_ = "HeadImage";
        ///<summary>
        ///Adjust控制面板中的应用识别码(退出第三方登录使用)
        ///</summary>
        public const string _GDPRAPPTOKEN_ = "GdprAppToken";
        ///<summary>
        ///Adjust设备标识符(退出第三方登录使用)
        ///</summary>
        public const string _GDPRAPPADID_ = "GdprAppAdid";
        ///<summary>
        ///邀请码
        ///</summary>
        public const string _INVITECODE_ = "InviteCode";
        ///<summary>
        ///产生邀请码的日期
        ///</summary>
        public const string _GENERATEINVITECODEDATETIME_ = "GenerateInviteCodeDateTime";
        ///<summary>
        ///产生邀请码的设备ID
        ///</summary>
        public const string _GENERATEINVITECODEDEVICEID_ = "GenerateInviteCodeDeviceID";
        ///<summary>
        ///我作为注册人是谁邀请我来注册的邀请人的UserID
        ///</summary>
        public const string _INVITEUSERID_ = "InviteUserID";
        ///<summary>
        ///我作为注册人注册时使用邀请码的日期
        ///</summary>
        public const string _USEINVITECODEDATETIME_ = "UseInviteCodeDateTime";
        ///<summary>
        ///我作为邀请人发出的邀请次数(废弃)
        ///</summary>
        public const string _INVITESENDTIMES_ = "InviteSendTimes";
        ///<summary>
        ///使用邀请码的设备ID（废弃）
        ///</summary>
        public const string _USEINVITECODEDEVICEID_ = "UseInviteCodeDeviceID";
        ///<summary>
        ///是否授权短信通知
        ///</summary>
        public const string _ISAUTHMESSAGE_ = "IsAuthMessage";
        ///<summary>
        ///授权短信通知时间
        ///</summary>
        public const string _AUTHMESSAGETIME_ = "AuthMessageTime";
        ///<summary>
        ///是否开启签到提醒
        ///</summary>
        public const string _ISSIGNINREMIND_ = "IsSigninRemind";
        #endregion

        #region 变量定义
        ///<summary>
        ///主键ID，自增ID
        ///</summary>
        private int _iD;
        ///<summary>
        ///用户ID，外键ID
        ///</summary>
        private int _userID;
        ///<summary>
        ///FirstName
        ///</summary>
        private string _firstName = "";
        ///<summary>
        ///FirstName
        ///</summary>
        private string _lastName = "";
        ///<summary>
        ///性别枚举类型：（男：0，女：1）
        ///</summary>
        private int _sex;
        ///<summary>
        ///职业类型枚举类型：(Teacher：0，Junior：1，Doctor：2，Engineer：3，Office Lady：4，Others：5)
        ///</summary>
        private int _jobType;
        ///<summary>
        ///出生日期
        ///</summary>
        private DateTime _birthDay = new DateTime(1900, 1, 1);
        ///<summary>
        ///身高
        ///</summary>
        private decimal _height;
        ///<summary>
        ///身高单位CM,INCH
        ///</summary>
        private string _heightUnit = "";
        ///<summary>
        ///体重
        ///</summary>
        private decimal _weight;
        ///<summary>
        ///体重单位KG,Lbs
        ///</summary>
        private string _weightUnit = "";
        ///<summary>
        ///胸围
        ///</summary>
        private int _bust;
        ///<summary>
        ///胸围单位CM,INCH
        ///</summary>
        private string _bustUnit = "";
        ///<summary>
        ///腰围
        ///</summary>
        private int _waist;
        ///<summary>
        ///腰围单位CM,INCH
        ///</summary>
        private string _waistUnit = "";
        ///<summary>
        ///臀围
        ///</summary>
        private int _hip;
        ///<summary>
        ///臀围单位CM,INCH
        ///</summary>
        private string _hipUnit = "";
        ///<summary>
        ///M,L,XL,XXL,3XL
        ///</summary>
        private string _dailySize = "";
        ///<summary>
        ///头像
        ///</summary>
        private string _headImage = "";
        ///<summary>
        ///Adjust控制面板中的应用识别码(退出第三方登录使用)
        ///</summary>
        private string _gdprAppToken = "";
        ///<summary>
        ///Adjust设备标识符(退出第三方登录使用)
        ///</summary>
        private string _gdprAppAdid = "";
        ///<summary>
        ///邀请码
        ///</summary>
        private string _inviteCode = "";
        ///<summary>
        ///产生邀请码的日期
        ///</summary>
        private DateTime _generateInviteCodeDateTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///产生邀请码的设备ID
        ///</summary>
        private string _generateInviteCodeDeviceID = "";
        ///<summary>
        ///我作为注册人是谁邀请我来注册的邀请人的UserID
        ///</summary>
        private int _inviteUserID;
        ///<summary>
        ///我作为注册人注册时使用邀请码的日期
        ///</summary>
        private DateTime _useInviteCodeDateTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///我作为邀请人发出的邀请次数(废弃)
        ///</summary>
        private int _inviteSendTimes;
        ///<summary>
        ///使用邀请码的设备ID（废弃）
        ///</summary>
        private string _useInviteCodeDeviceID = "";
        ///<summary>
        ///是否授权短信通知
        ///</summary>
        private int _isAuthMessage;
        ///<summary>
        ///授权短信通知时间
        ///</summary>
        private DateTime _authMessageTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///是否开启签到提醒
        ///</summary>
        private int _isSigninRemind;


        #endregion

        #region 构造函数
        ///<summary>
        ///用户基本信息表(user_info表的补充表)
        ///</summary>
        public User_info_extend()
        {
        }
        ///<summary>
        ///用户基本信息表(user_info表的补充表)
        ///</summary>
        public User_info_extend
        (
            int userID,
            string firstName,
            string lastName,
            int sex,
            int jobType,
            DateTime birthDay,
            decimal height,
            string heightUnit,
            decimal weight,
            string weightUnit,
            int bust,
            string bustUnit,
            int waist,
            string waistUnit,
            int hip,
            string hipUnit,
            string dailySize,
            string headImage,
            string gdprAppToken,
            string gdprAppAdid,
            string inviteCode,
            DateTime generateInviteCodeDateTime,
            string generateInviteCodeDeviceID,
            int inviteUserID,
            DateTime useInviteCodeDateTime,
            int inviteSendTimes,
            string useInviteCodeDeviceID,
            int isAuthMessage,
            DateTime authMessageTime,
            int isSigninRemind
        )
        {
            _userID = userID;
            _firstName = firstName;
            _lastName = lastName;
            _sex = sex;
            _jobType = jobType;
            _birthDay = birthDay;
            _height = height;
            _heightUnit = heightUnit;
            _weight = weight;
            _weightUnit = weightUnit;
            _bust = bust;
            _bustUnit = bustUnit;
            _waist = waist;
            _waistUnit = waistUnit;
            _hip = hip;
            _hipUnit = hipUnit;
            _dailySize = dailySize;
            _headImage = headImage;
            _gdprAppToken = gdprAppToken;
            _gdprAppAdid = gdprAppAdid;
            _inviteCode = inviteCode;
            _generateInviteCodeDateTime = generateInviteCodeDateTime;
            _generateInviteCodeDeviceID = generateInviteCodeDeviceID;
            _inviteUserID = inviteUserID;
            _useInviteCodeDateTime = useInviteCodeDateTime;
            _inviteSendTimes = inviteSendTimes;
            _useInviteCodeDeviceID = useInviteCodeDeviceID;
            _isAuthMessage = isAuthMessage;
            _authMessageTime = authMessageTime;
            _isSigninRemind = isSigninRemind;

        }
        #endregion

        #region 公共属性

        ///<summary>
        ///主键ID，自增ID
        ///</summary>
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///用户ID，外键ID
        ///</summary>
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        ///<summary>
        ///FirstName
        ///</summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        ///<summary>
        ///FirstName
        ///</summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        ///<summary>
        ///性别枚举类型：（男：0，女：1）
        ///</summary>
        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        ///<summary>
        ///职业类型枚举类型：(Teacher：0，Junior：1，Doctor：2，Engineer：3，Office Lady：4，Others：5)
        ///</summary>
        public int JobType
        {
            get { return _jobType; }
            set { _jobType = value; }
        }

        ///<summary>
        ///出生日期
        ///</summary>
        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }

        ///<summary>
        ///身高
        ///</summary>
        public decimal Height
        {
            get { return _height; }
            set { _height = value; }
        }

        ///<summary>
        ///身高单位CM,INCH
        ///</summary>
        public string HeightUnit
        {
            get { return _heightUnit; }
            set { _heightUnit = value; }
        }

        ///<summary>
        ///体重
        ///</summary>
        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        ///<summary>
        ///体重单位KG,Lbs
        ///</summary>
        public string WeightUnit
        {
            get { return _weightUnit; }
            set { _weightUnit = value; }
        }

        ///<summary>
        ///胸围
        ///</summary>
        public int Bust
        {
            get { return _bust; }
            set { _bust = value; }
        }

        ///<summary>
        ///胸围单位CM,INCH
        ///</summary>
        public string BustUnit
        {
            get { return _bustUnit; }
            set { _bustUnit = value; }
        }

        ///<summary>
        ///腰围
        ///</summary>
        public int Waist
        {
            get { return _waist; }
            set { _waist = value; }
        }

        ///<summary>
        ///腰围单位CM,INCH
        ///</summary>
        public string WaistUnit
        {
            get { return _waistUnit; }
            set { _waistUnit = value; }
        }

        ///<summary>
        ///臀围
        ///</summary>
        public int Hip
        {
            get { return _hip; }
            set { _hip = value; }
        }

        ///<summary>
        ///臀围单位CM,INCH
        ///</summary>
        public string HipUnit
        {
            get { return _hipUnit; }
            set { _hipUnit = value; }
        }

        ///<summary>
        ///M,L,XL,XXL,3XL
        ///</summary>
        public string DailySize
        {
            get { return _dailySize; }
            set { _dailySize = value; }
        }

        ///<summary>
        ///头像
        ///</summary>
        public string HeadImage
        {
            get { return _headImage; }
            set { _headImage = value; }
        }

        ///<summary>
        ///Adjust控制面板中的应用识别码(退出第三方登录使用)
        ///</summary>
        public string GdprAppToken
        {
            get { return _gdprAppToken; }
            set { _gdprAppToken = value; }
        }

        ///<summary>
        ///Adjust设备标识符(退出第三方登录使用)
        ///</summary>
        public string GdprAppAdid
        {
            get { return _gdprAppAdid; }
            set { _gdprAppAdid = value; }
        }

        ///<summary>
        ///邀请码
        ///</summary>
        public string InviteCode
        {
            get { return _inviteCode; }
            set { _inviteCode = value; }
        }

        ///<summary>
        ///产生邀请码的日期
        ///</summary>
        public DateTime GenerateInviteCodeDateTime
        {
            get { return _generateInviteCodeDateTime; }
            set { _generateInviteCodeDateTime = value; }
        }

        ///<summary>
        ///产生邀请码的设备ID
        ///</summary>
        public string GenerateInviteCodeDeviceID
        {
            get { return _generateInviteCodeDeviceID; }
            set { _generateInviteCodeDeviceID = value; }
        }

        ///<summary>
        ///我作为注册人是谁邀请我来注册的邀请人的UserID
        ///</summary>
        public int InviteUserID
        {
            get { return _inviteUserID; }
            set { _inviteUserID = value; }
        }

        ///<summary>
        ///我作为注册人注册时使用邀请码的日期
        ///</summary>
        public DateTime UseInviteCodeDateTime
        {
            get { return _useInviteCodeDateTime; }
            set { _useInviteCodeDateTime = value; }
        }

        ///<summary>
        ///我作为邀请人发出的邀请次数(废弃)
        ///</summary>
        public int InviteSendTimes
        {
            get { return _inviteSendTimes; }
            set { _inviteSendTimes = value; }
        }

        ///<summary>
        ///使用邀请码的设备ID（废弃）
        ///</summary>
        public string UseInviteCodeDeviceID
        {
            get { return _useInviteCodeDeviceID; }
            set { _useInviteCodeDeviceID = value; }
        }

        ///<summary>
        ///是否授权短信通知
        ///</summary>
        public int IsAuthMessage
        {
            get { return _isAuthMessage; }
            set { _isAuthMessage = value; }
        }

        ///<summary>
        ///授权短信通知时间
        ///</summary>
        public DateTime AuthMessageTime
        {
            get { return _authMessageTime; }
            set { _authMessageTime = value; }
        }

        ///<summary>
        ///是否开启签到提醒
        ///</summary>
        public int IsSigninRemind
        {
            get { return _isSigninRemind; }
            set { _isSigninRemind = value; }
        }



        #endregion

        #region 重写的方法
        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is User_info_extend)
            {
                result = (obj as User_info_extend).ID == this.ID;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
