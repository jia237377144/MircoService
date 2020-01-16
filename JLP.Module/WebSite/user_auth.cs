/******************************************
* 模块名称：实体 用户第三方授权登录信息
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
	/// 实体 用户第三方授权登录信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_auth
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户第三方授权登录信息
        /// </summary>
        public user_auth(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _token = null;
        private Int32 _regtype = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 用户编号，外键ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 第三方登录Token
        /// </summary>
        public string Token
        {
            set{ _token=value;}
            get{return _token;}
        }
        /// <summary>
        /// 用户注册类型枚举：（采用之前的枚举，如facebook,twritter）
        /// </summary>
        public Int32 RegType
        {
            set{ _regtype=value;}
            get{return _regtype;}
        }
        #endregion
	}
}
