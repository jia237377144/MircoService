/******************************************
* 模块名称：实体 用户签到表
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
	/// 实体 用户签到表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_signin
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户签到表
        /// </summary>
        public user_signin(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _days = Int32.MinValue;
        private Int32 _signintype = Int32.MinValue;
        private Int32 _signinid = Int32.MinValue;
        private DateTime _signintime = DateTime.MinValue;
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
        /// 用户连续签到天数
        /// </summary>
        public Int32 Days
        {
            set{ _days=value;}
            get{return _days;}
        }
        /// <summary>
        /// 签到类型，枚举类型
        /// </summary>
        public Int32 SigninType
        {
            set{ _signintype=value;}
            get{return _signintype;}
        }
        /// <summary>
        /// 签到活动的ID，外键ID
        /// </summary>
        public Int32 SigninID
        {
            set{ _signinid=value;}
            get{return _signinid;}
        }
        /// <summary>
        /// 签到时间
        /// </summary>
        public DateTime SigninTime
        {
            set{ _signintime=value;}
            get{return _signintime;}
        }
        /// <summary>
        /// 添加记录时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        #endregion
	}
}
