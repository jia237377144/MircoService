/******************************************
* 模块名称：实体 记录每条消息的跟踪记录 包括系统消息和手动消息
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
	/// 实体 记录每条消息的跟踪记录 包括系统消息和手动消息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_app_msg_trace
	{
        #region 构造函数
        /// <summary>
        /// 实体 记录每条消息的跟踪记录 包括系统消息和手动消息
        /// </summary>
        public user_app_msg_trace(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _contentid = Int32.MinValue;
        private Int32 _devicetype = Int32.MinValue;
        private Int32 _appmappingid = Int32.MinValue;
        private string _devicetoken = null;
        private Int32 _status = Int32.MinValue;
        private string _errorreasons = null;
        private Int32 _isread = Int32.MinValue;
        private DateTime _sendtime = DateTime.MinValue;
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
        /// 内容ID，外键ID
        /// </summary>
        public Int32 ContentID
        {
            set{ _contentid=value;}
            get{return _contentid;}
        }
        /// <summary>
        /// 设备类型 枚举
        /// </summary>
        public Int32 DeviceType
        {
            set{ _devicetype=value;}
            get{return _devicetype;}
        }
        /// <summary>
        /// 设备信息表主键ID，外键ID
        /// </summary>
        public Int32 AppMappingID
        {
            set{ _appmappingid=value;}
            get{return _appmappingid;}
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
        /// 推送状态 成功或失败
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 错误原因,SDK枚举文本
        /// </summary>
        public string ErrorReasons
        {
            set{ _errorreasons=value;}
            get{return _errorreasons;}
        }
        /// <summary>
        /// IsRead
        /// </summary>
        public Int32 IsRead
        {
            set{ _isread=value;}
            get{return _isread;}
        }
        /// <summary>
        /// SendTime
        /// </summary>
        public DateTime SendTime
        {
            set{ _sendtime=value;}
            get{return _sendtime;}
        }
        #endregion
	}
}
