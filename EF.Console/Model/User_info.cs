using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.Model
{
    public class User_info
    {

        #region 常量
        ///<summary>
        ///网站注册用户信息表
        ///</summary>
        public const string _USER_INFO_ = "user_info";
        ///<summary>
        ///主键，自增ID
        ///</summary>
        public const string _ID_ = "ID";
        ///<summary>
        ///登录邮箱（等同于登录名称）
        ///</summary>
        public const string _EMAIL_ = "Email";
        ///<summary>
        ///登录密码（MD5加密）
        ///</summary>
        public const string _PASSWORD_ = "Password";
        ///<summary>
        ///注册时间
        ///</summary>
        public const string _REGDATE_ = "RegDate";
        ///<summary>
        ///注册IP
        ///</summary>
        public const string _REGIP_ = "RegIP";
        ///<summary>
        ///用户注册类型枚举：（采用之前的枚举，如facebook,twritter）
        ///</summary>
        public const string _REGTYPE_ = "RegType";
        ///<summary>
        ///用户最后登录时间
        ///</summary>
        public const string _LASTLOGINDATE_ = "LastLoginDate";
        ///<summary>
        ///用户最后登录IP
        ///</summary>
        public const string _LASTLOGINIP_ = "LastLoginIP";
        ///<summary>
        ///在哪个语言站注册的
        ///</summary>
        public const string _CULTUREID_ = "CultureID";
        ///<summary>
        ///用户等级（枚举类型：EMemberLevel）
        ///</summary>
        public const string _USERLEVEL_ = "UserLevel";
        ///<summary>
        ///用户注册平台枚举（网站，M，App）
        ///</summary>
        public const string _PLATFORM_ = "Platform";
        ///<summary>
        ///同意最新条款时间
        ///</summary>
        public const string _LASTAGREETERMSDATE_ = "LastAgreeTermsDate";
        ///<summary>
        ///是否已验证邮箱(1-已验证，0-未验证)
        ///</summary>
        public const string _ISVERIFYEMAIL_ = "IsVerifyEmail";
        ///<summary>
        ///用户状态枚举（采用之前的枚举，如：启用，禁用，黑名单）
        ///</summary>
        public const string _STATUS_ = "Status";
        ///<summary>
        ///会员级别枚举类型(系统、赠送、邀请)
        ///</summary>
        public const string _USERLEVELTYPE_ = "UserLevelType";
        ///<summary>
        ///会员级别有效期的开始时间(不包含包括会员级别枚举类型为系统类型)
        ///</summary>
        public const string _USERLEVELSTARTTIME_ = "UserLevelStartTime";
        ///<summary>
        ///会员级别有效期的结束时间(不包含包括会员级别枚举类型为系统类型))
        ///</summary>
        public const string _USERLEVELENDTIME_ = "UserLevelEndTime";
        #endregion

        #region 变量定义
        ///<summary>
        ///主键，自增ID
        ///</summary>
        private int _iD;
        ///<summary>
        ///登录邮箱（等同于登录名称）
        ///</summary>
        private string _email = "";
        ///<summary>
        ///登录密码（MD5加密）
        ///</summary>
        private string _password = "";
        ///<summary>
        ///注册时间
        ///</summary>
        private DateTime _regDate = new DateTime(1900, 1, 1);
        ///<summary>
        ///注册IP
        ///</summary>
        private string _regIP = "";
        ///<summary>
        ///用户注册类型枚举：（采用之前的枚举，如facebook,twritter）
        ///</summary>
        private int _regType;
        ///<summary>
        ///用户最后登录时间
        ///</summary>
        private DateTime _lastLoginDate = new DateTime(1900, 1, 1);
        ///<summary>
        ///用户最后登录IP
        ///</summary>
        private string _lastLoginIP = "";
        ///<summary>
        ///在哪个语言站注册的
        ///</summary>
        private int _cultureID;
        ///<summary>
        ///用户等级（枚举类型：EMemberLevel）
        ///</summary>
        private int _userLevel;
        ///<summary>
        ///用户注册平台枚举（网站，M，App）
        ///</summary>
        private int _platform;
        ///<summary>
        ///同意最新条款时间
        ///</summary>
        private DateTime _lastAgreeTermsDate = new DateTime(1900, 1, 1);
        ///<summary>
        ///是否已验证邮箱(1-已验证，0-未验证)
        ///</summary>
        private int _isVerifyEmail;
        ///<summary>
        ///用户状态枚举（采用之前的枚举，如：启用，禁用，黑名单）
        ///</summary>
        private int _status = 1;
        ///<summary>
        ///会员级别枚举类型(系统、赠送、邀请)
        ///</summary>
        private int _userLevelType;
        ///<summary>
        ///会员级别有效期的开始时间(不包含包括会员级别枚举类型为系统类型)
        ///</summary>
        private DateTime _userLevelStartTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///会员级别有效期的结束时间(不包含包括会员级别枚举类型为系统类型))
        ///</summary>
        private DateTime _userLevelEndTime = new DateTime(1900, 1, 1);


        #endregion

        #region 构造函数
        ///<summary>
        ///网站注册用户信息表
        ///</summary>
        public User_info()
        {
        }
        ///<summary>
        ///网站注册用户信息表
        ///</summary>
        public User_info
        (
            string email,
            string password,
            DateTime regDate,
            string regIP,
            int regType,
            DateTime lastLoginDate,
            string lastLoginIP,
            int cultureID,
            int userLevel,
            int platform,
            DateTime lastAgreeTermsDate,
            int isVerifyEmail,
            int status,
            int userLevelType,
            DateTime userLevelStartTime,
            DateTime userLevelEndTime
        )
        {
            _email = email;
            _password = password;
            _regDate = regDate;
            _regIP = regIP;
            _regType = regType;
            _lastLoginDate = lastLoginDate;
            _lastLoginIP = lastLoginIP;
            _cultureID = cultureID;
            _userLevel = userLevel;
            _platform = platform;
            _lastAgreeTermsDate = lastAgreeTermsDate;
            _isVerifyEmail = isVerifyEmail;
            _status = status;
            _userLevelType = userLevelType;
            _userLevelStartTime = userLevelStartTime;
            _userLevelEndTime = userLevelEndTime;

        }
        #endregion

        #region 公共属性

        ///<summary>
        ///主键，自增ID
        ///</summary>
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///登录邮箱（等同于登录名称）
        ///</summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        ///<summary>
        ///登录密码（MD5加密）
        ///</summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        ///<summary>
        ///注册时间
        ///</summary>
        public DateTime RegDate
        {
            get { return _regDate; }
            set { _regDate = value; }
        }

        ///<summary>
        ///注册IP
        ///</summary>
        public string RegIP
        {
            get { return _regIP; }
            set { _regIP = value; }
        }

        ///<summary>
        ///用户注册类型枚举：（采用之前的枚举，如facebook,twritter）
        ///</summary>
        public int RegType
        {
            get { return _regType; }
            set { _regType = value; }
        }

        ///<summary>
        ///用户最后登录时间
        ///</summary>
        public DateTime LastLoginDate
        {
            get { return _lastLoginDate; }
            set { _lastLoginDate = value; }
        }

        ///<summary>
        ///用户最后登录IP
        ///</summary>
        public string LastLoginIP
        {
            get { return _lastLoginIP; }
            set { _lastLoginIP = value; }
        }

        ///<summary>
        ///在哪个语言站注册的
        ///</summary>
        public int CultureID
        {
            get { return _cultureID; }
            set { _cultureID = value; }
        }

        ///<summary>
        ///用户等级（枚举类型：EMemberLevel）
        ///</summary>
        public int UserLevel
        {
            get { return _userLevel; }
            set { _userLevel = value; }
        }

        ///<summary>
        ///用户注册平台枚举（网站，M，App）
        ///</summary>
        public int Platform
        {
            get { return _platform; }
            set { _platform = value; }
        }

        ///<summary>
        ///同意最新条款时间
        ///</summary>
        public DateTime LastAgreeTermsDate
        {
            get { return _lastAgreeTermsDate; }
            set { _lastAgreeTermsDate = value; }
        }

        ///<summary>
        ///是否已验证邮箱(1-已验证，0-未验证)
        ///</summary>
        public int IsVerifyEmail
        {
            get { return _isVerifyEmail; }
            set { _isVerifyEmail = value; }
        }

        ///<summary>
        ///用户状态枚举（采用之前的枚举，如：启用，禁用，黑名单）
        ///</summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        ///<summary>
        ///会员级别枚举类型(系统、赠送、邀请)
        ///</summary>
        public int UserLevelType
        {
            get { return _userLevelType; }
            set { _userLevelType = value; }
        }

        ///<summary>
        ///会员级别有效期的开始时间(不包含包括会员级别枚举类型为系统类型)
        ///</summary>
        public DateTime UserLevelStartTime
        {
            get { return _userLevelStartTime; }
            set { _userLevelStartTime = value; }
        }

        ///<summary>
        ///会员级别有效期的结束时间(不包含包括会员级别枚举类型为系统类型))
        ///</summary>
        public DateTime UserLevelEndTime
        {
            get { return _userLevelEndTime; }
            set { _userLevelEndTime = value; }
        }

        public User_info_extend UserInfoExtend { get; set; }


        #endregion

        #region 重写的方法
        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is User_info)
            {
                result = (obj as User_info).ID == this.ID;
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
