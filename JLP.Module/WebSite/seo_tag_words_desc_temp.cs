/******************************************
* 模块名称：实体 seo_tag_words_desc_temp
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
	/// 实体 seo_tag_words_desc_temp
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class seo_tag_words_desc_temp
	{
        #region 构造函数
        /// <summary>
        /// 实体 seo_tag_words_desc_temp
        /// </summary>
        public seo_tag_words_desc_temp(){}
        #endregion

        #region 私有变量
        private string _keywords = null;
        private string _descriptions = null;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _lgid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// KeyWords
        /// </summary>
        public string KeyWords
        {
            set{ _keywords=value;}
            get{return _keywords;}
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
        /// SiteID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// LgID
        /// </summary>
        public Int32 LgID
        {
            set{ _lgid=value;}
            get{return _lgid;}
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
        /// ADDDATE
        /// </summary>
        public DateTime ADDDATE
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        #endregion
	}
}
