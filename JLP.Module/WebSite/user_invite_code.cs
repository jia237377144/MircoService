/******************************************
* 模块名称：实体 用户邀请码
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
	/// 实体 用户邀请码
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_invite_code
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户邀请码
        /// </summary>
        public user_invite_code(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _invitecode = null;
        private DateTime _generateinvitecodedatetime = DateTime.MinValue;
        private string _generateinvitecodedeviceid = null;
        private string _useinvitecodedeviceid = null;
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
