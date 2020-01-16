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
	public class seo_tag_keys_group
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
        /// </summary>
        public seo_tag_keys_group(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _groupname = null;
        private string _metatitle = null;
        private string _metakeyword = null;
        private string _metadesc = null;
        private Int32 _siteid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private Int32 _state = Int32.MinValue;
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
        /// 分组名称
        /// </summary>
        public string GroupName
        {
            set{ _groupname=value;}
            get{return _groupname;}
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
        /// MetaKeyWord
        /// </summary>
        public string MetaKeyWord
        {
            set{ _metakeyword=value;}
            get{return _metakeyword;}
        }
        /// <summary>
        /// meta描述
        /// </summary>
        public string MetaDesc
        {
            set{ _metadesc=value;}
            get{return _metadesc;}
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
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        /// <summary>
        /// 状态【0：启用 1：禁用】
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// 语言ID
        /// </summary>
        public Int32 LanguageId
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        #endregion
	}
}
