/******************************************
* 模块名称：实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据【搜索联想表】
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
	/// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据【搜索联想表】
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_tag_search_key_new
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据【搜索联想表】
        /// </summary>
        public seo_tag_search_key_new(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _keyname = null;
        private Int32 _searchcounts = Int32.MinValue;
        private Int32 _siteid = Int32.MinValue;
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
        public Int32 SearchCounts
        {
            set{ _searchcounts=value;}
            get{return _searchcounts;}
        }
        /// <summary>
        /// 站点ID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        /// <summary>
        /// 语言ID
        /// </summary>
        public Int32 LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        #endregion
	}
}
