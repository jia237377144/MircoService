/******************************************
* 模块名称：实体 用户IOS设备信息
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
	/// 实体 用户IOS设备信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_app_ios_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户IOS设备信息
        /// </summary>
        public user_app_ios_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _deviceid = null;
        private string _devicetoken = null;
        private string _devicename = null;
        private string _osversion = null;
        private string _appversion = null;
        private string _country = null;
        private string _language = null;
        private Int32 _status = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// 设备ID
        /// </summary>
        public string DeviceID
        {
            set{ _deviceid=value;}
            get{return _deviceid;}
        }
        /// <summary>
        /// 设备允许接收通知的唯一ID
        /// </summary>
        public string DeviceToken
        {
            set{ _devicetoken=value;}
            get{return _devicetoken;}
        }
        /// <summary>
        /// DeviceName
        /// </summary>
        public string DeviceName
        {
            set{ _devicename=value;}
            get{return _devicename;}
        }
        /// <summary>
        /// IOS操作系统版本
        /// </summary>
        public string OSVersion
        {
            set{ _osversion=value;}
            get{return _osversion;}
        }
        /// <summary>
        /// App软件版本
        /// </summary>
        public string AppVersion
        {
            set{ _appversion=value;}
            get{return _appversion;}
        }
        /// <summary>
        /// 国家信息
        /// </summary>
        public string Country
        {
            set{ _country=value;}
            get{return _country;}
        }
        /// <summary>
        /// 语言信息
        /// </summary>
        public string Language
        {
            set{ _language=value;}
            get{return _language;}
        }
        /// <summary>
        /// 设备状态EStatus枚举类型（0测试设备，1正式设备）
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        #endregion
	}
}
