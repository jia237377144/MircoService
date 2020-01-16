/******************************************
* 模块名称：实体 节日专题产品标签表
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
	/// 实体 节日专题产品标签表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_holiday_label
	{
        #region 构造函数
        /// <summary>
        /// 实体 节日专题产品标签表
        /// </summary>
        public topic_holiday_label(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topicholidayid = Int32.MinValue;
        private string _title = null;
        private Int32 _scopetype = Int32.MinValue;
        private string _leimujson = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
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
        /// topic_holiday表的主键ID
        /// </summary>
        public Int32 TopicHolidayID
        {
            set{ _topicholidayid=value;}
            get{return _topicholidayid;}
        }
        /// <summary>
        /// 标签标题
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 作用类型,枚举EActive_List_ScopeLeiMuOrPinLei
        /// </summary>
        public Int32 ScopeType
        {
            set{ _scopetype=value;}
            get{return _scopetype;}
        }
        /// <summary>
        /// 可配置的一个类目
        /// </summary>
        public string LeiMuJSON
        {
            set{ _leimujson=value;}
            get{return _leimujson;}
        }
        /// <summary>
        /// 状态 ,ETopic_Label_Status
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 排序
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
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
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
