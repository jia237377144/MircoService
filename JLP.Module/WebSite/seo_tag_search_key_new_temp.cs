/******************************************
* 模块名称：实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据【搜索联想表-副表】
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
	/// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据【搜索联想表-副表】
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_tag_search_key_new_temp
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据【搜索联想表-副表】
        /// </summary>
        public seo_tag_search_key_new_temp(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _keyname = null;
        private string _searchcounts = null;
        private string _siteid = null;
        private string _languageid = null;
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
        /// 搜索词
        /// </summary>
        public string KeyName
        {
            set{ _keyname=value;}
            get{return _keyname;}
        }
        /// <summary>
        /// 搜索次数
        /// </summary>
        public string SearchCounts
        {
            set{ _searchcounts=value;}
            get{return _searchcounts;}
        }
        /// <summary>
        /// 站点ID
        /// </summary>
        public string SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// 语言ID
        /// </summary>
        public string LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        #endregion
	}
}
