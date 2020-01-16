/******************************************
* 模块名称：实体 app用户订阅闪购产品信息表
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
	/// 实体 app用户订阅闪购产品信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_app_msg_flashsale_subscribe
	{
        #region 构造函数
        /// <summary>
        /// 实体 app用户订阅闪购产品信息表
        /// </summary>
        public user_app_msg_flashsale_subscribe(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _flashid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _deviceid = null;
        private string _devicetoken = null;
        private Int32 _devicetype = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
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
        /// 闪购ID，外键ID
        /// </summary>
        public Int32 FlashID
        {
            set{ _flashid=value;}
            get{return _flashid;}
        }
        /// <summary>
        /// PID，外键ID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// SPUID，外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
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
        /// 设备ID，移动设备唯一标识
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
        /// 设备类型枚举
        /// </summary>
        public Int32 DeviceType
        {
            set{ _devicetype=value;}
            get{return _devicetype;}
        }
        /// <summary>
        /// 状态枚举 1=待推送  2=已发送
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 订阅时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        #endregion
	}
}
