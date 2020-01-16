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
	public class view_topic_holiday_list
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_topic_holiday_list(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topickey = Int32.MinValue;
        private string _name = null;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private string _entryimagesrc = null;
        private string _bannerimagesrc = null;
        private Int32 _state = Int32.MinValue;
        private string _url = null;
        private string _metatitle = null;
        private string _metakeywords = null;
        private string _metadescription = null;
        private string _topicdescriptionjson = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 关联的专题ID 手动录入的
        /// </summary>
        public Int32 TopicKey
        {
            set{ _topickey=value;}
            get{return _topickey;}
        }
        /// <summary>
        /// 节日专题名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 专题活动开始时间
        /// </summary>
        public DateTime StartTime
        {
            set{ _starttime=value;}
            get{return _starttime;}
        }
        /// <summary>
        /// 专题活动结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
        }
        /// <summary>
        /// 聚合页节日专题入口的图片
        /// </summary>
        public string EntryImageSrc
        {
            set{ _entryimagesrc=value;}
            get{return _entryimagesrc;}
        }
        /// <summary>
        /// 节日专题详情页顶部banner图片地址
        /// </summary>
        public string BannerImageSrc
        {
            set{ _bannerimagesrc=value;}
            get{return _bannerimagesrc;}
        }
        /// <summary>
        /// 控制状态枚举：1：显示，0：隐藏
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// URL地址（聚合页指向节日专题页的地址）
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 节日专题页meta标题
        /// </summary>
        public string MetaTitle
        {
            set{ _metatitle=value;}
            get{return _metatitle;}
        }
        /// <summary>
        /// 节日专题页meta关键字
        /// </summary>
        public string MetaKeywords
        {
            set{ _metakeywords=value;}
            get{return _metakeywords;}
        }
        /// <summary>
        /// 节日专题页meta说明
        /// </summary>
        public string MetaDescription
        {
            set{ _metadescription=value;}
            get{return _metadescription;}
        }
        /// <summary>
        /// 节日专题页面描述（包括顶部中部底部，非必填）
        /// </summary>
        public string TopicDescriptionJSON
        {
            set{ _topicdescriptionjson=value;}
            get{return _topicdescriptionjson;}
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
