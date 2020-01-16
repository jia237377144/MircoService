/******************************************
* 模块名称：实体 VIEW
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
	/// 实体 VIEW
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class view_active_order_grouplist
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_active_order_grouplist(){}
        #endregion

        #region 私有变量
        private string _date = null;
        private Int32 _activelistid = Int32.MinValue;
        private long _ordercount = long.MinValue;
        private string _activename = null;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// Date
        /// </summary>
        public string Date
        {
            set{ _date=value;}
            get{return _date;}
        }
        /// <summary>
        /// 活动列表ID，外键ID
        /// </summary>
        public Int32 ActiveListId
        {
            set{ _activelistid=value;}
            get{return _activelistid;}
        }
        /// <summary>
        /// OrderCount(NOT NULL)
        /// </summary>
        public long OrderCount
        {
            set{ _ordercount=value;}
            get{return _ordercount;}
        }
        /// <summary>
        /// 细则名称
        /// </summary>
        public string ActiveName
        {
            set{ _activename=value;}
            get{return _activename;}
        }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime StartTime
        {
            set{ _starttime=value;}
            get{return _starttime;}
        }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
        }
        #endregion
	}
}
