/******************************************
* 模块名称：实体 预售表
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
	/// 实体 预售表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class presale_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 预售表
        /// </summary>
        public presale_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private Int32 _pretype = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _tooltip = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
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
        /// 预售名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime
        {
            set{ _starttime=value;}
            get{return _starttime;}
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
        }
        /// <summary>
        /// 预售类型   EProduct_PreSaleType
        /// </summary>
        public Int32 PreType
        {
            set{ _pretype=value;}
            get{return _pretype;}
        }
        /// <summary>
        /// 通用的状态枚举 EStatus
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 工具框提示
        /// </summary>
        public string ToolTip
        {
            set{ _tooltip=value;}
            get{return _tooltip;}
        }
        /// <summary>
        /// CreateUserName
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        #endregion
	}
}
