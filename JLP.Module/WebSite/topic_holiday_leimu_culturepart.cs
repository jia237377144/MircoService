/******************************************
* 模块名称：实体 节日类目页多语言表
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
	/// 实体 节日类目页多语言表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_holiday_leimu_culturepart
	{
        #region 构造函数
        /// <summary>
        /// 实体 节日类目页多语言表
        /// </summary>
        public topic_holiday_leimu_culturepart(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topicid = Int32.MinValue;
        private Int32 _topicholidayleimuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private string _metatitle = null;
        private string _metakeywords = null;
        private string _metadescription = null;
        private string _leimudescriptionjson = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 貌似没用了
        /// </summary>
        public Int32 TopicID
        {
            set{ _topicid=value;}
            get{return _topicid;}
        }
        /// <summary>
        /// topic_holiday_leimu表的主键ID
        /// </summary>
        public Int32 TopicHolidayLeiMuID
        {
            set{ _topicholidayleimuid=value;}
            get{return _topicholidayleimuid;}
        }
        /// <summary>
        /// 多语言ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
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
        /// meta标题
        /// </summary>
        public string MetaTitle
        {
            set{ _metatitle=value;}
            get{return _metatitle;}
        }
        /// <summary>
        /// meta关键字
        /// </summary>
        public string MetaKeywords
        {
            set{ _metakeywords=value;}
            get{return _metakeywords;}
        }
        /// <summary>
        /// meta说明
        /// </summary>
        public string MetaDescription
        {
            set{ _metadescription=value;}
            get{return _metadescription;}
        }
        /// <summary>
        /// 节日类目页描述（包括顶部中部底部，非必填）
        /// </summary>
        public string LeiMuDescriptionJSON
        {
            set{ _leimudescriptionjson=value;}
            get{return _leimudescriptionjson;}
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
