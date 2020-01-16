/******************************************
* 模块名称：实体 用户记录访问
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
	/// 实体 用户记录访问
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_msg_visit_time
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户记录访问
        /// </summary>
        public user_msg_visit_time(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _msgtype = Int32.MinValue;
        private DateTime _lastvisittime = DateTime.MinValue;
        private Int32 _status = Int32.MinValue;
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
        /// 访问消息类型
        /// </summary>
        public Int32 MsgType
        {
            set{ _msgtype=value;}
            get{return _msgtype;}
        }
        /// <summary>
        /// 最后一次访问消息时间
        /// </summary>
        public DateTime LastVisitTime
        {
            set{ _lastvisittime=value;}
            get{return _lastvisittime;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        #endregion
	}
}
