/******************************************
* 模块名称：实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
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
	/// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_tag_words_desc
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
        /// </summary>
        public seo_tag_words_desc(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _keywords = null;
        private DateTime _adddate = DateTime.MinValue;
        private string _descriptions = null;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _lgid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
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
        /// KeyWords
        /// </summary>
        public string KeyWords
        {
            set{ _keywords=value;}
            get{return _keywords;}
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
        /// 页面描述
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
        /// 【语言ID】
        /// </summary>
        public Int32 LgID
        {
            set{ _lgid=value;}
            get{return _lgid;}
        }
        /// <summary>
        /// 【类目ID】
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        #endregion
	}
}
