/******************************************
* 模块名称：实体 seo_tag_count_log
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
	/// 实体 seo_tag_count_log
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_tag_count_log
	{
        #region 构造函数
        /// <summary>
        /// 实体 seo_tag_count_log
        /// </summary>
        public seo_tag_count_log(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _siteid = Int32.MinValue;
        private string _name = null;
        private Int32 _logcount = Int32.MinValue;
        private Int32 _typeid = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private Int32 _languageid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SiteID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// LogCount
        /// </summary>
        public Int32 LogCount
        {
            set{ _logcount=value;}
            get{return _logcount;}
        }
        /// <summary>
        /// TypeID
        /// </summary>
        public Int32 TypeID
        {
            set{ _typeid=value;}
            get{return _typeid;}
        }
        /// <summary>
        /// State
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// AddDate
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        /// <summary>
        /// LanguageID
        /// </summary>
        public Int32 LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        #endregion
	}
}
