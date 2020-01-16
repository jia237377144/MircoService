/******************************************
* 模块名称：实体 seo_tag_category_tag_meta
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
	/// 实体 seo_tag_category_tag_meta
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_tag_category_tag_meta
	{
        #region 构造函数
        /// <summary>
        /// 实体 seo_tag_category_tag_meta
        /// </summary>
        public seo_tag_category_tag_meta(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private Int32 _siteid = Int32.MinValue;
        private string _title = null;
        private string _keywords = null;
        private string _description = null;
        private string _descriptions = null;
        private Int32 _languageid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private Int32 _state = Int32.MinValue;
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
        /// CategoryID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
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
        /// Title
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// Keywords
        /// </summary>
        public string Keywords
        {
            set{ _keywords=value;}
            get{return _keywords;}
        }
        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            set{ _description=value;}
            get{return _description;}
        }
        /// <summary>
        /// Descriptions
        /// </summary>
        public string Descriptions
        {
            set{ _descriptions=value;}
            get{return _descriptions;}
        }
        /// <summary>
        /// LanguageID
        /// </summary>
        public Int32 LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
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
        /// State
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        #endregion
	}
}
