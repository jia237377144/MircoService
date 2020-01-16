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
	[Description("Primary:id")]
    [Serializable]
	public class seo_tag_keys
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
        /// </summary>
        public seo_tag_keys(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private string _categoryids = null;
        private Int32 _categoryid = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private Int32 _ishot = Int32.MinValue;
        private Int32 _source = Int32.MinValue;
        private decimal _searchnum = decimal.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private string _tourl = null;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _typeid = Int32.MinValue;
        private string _competition = null;
        private string _descriptions = null;
        private Int32 _isvaluekey = Int32.MinValue;
        private Int32 _groupid = Int32.MinValue;
        private string _title = null;
        private string _keywords = null;
        private string _description = null;
        private Int32 _searchcount = Int32.MinValue;
        private string _comlevel = null;
        private string _firstword = null;
        private string _enname = null;
        private Int32 _languageid = Int32.MinValue;
        private Int32 _seoid = Int32.MinValue;
        private Int32 _style = Int32.MinValue;
        private string _brandname = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 id(NOT NULL)
        /// </summary>
        public Int32 id
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 关键词
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 关键词首字母(NOT NULL)
        /// </summary>
        public string CategoryIDs
        {
            set{ _categoryids=value;}
            get{return _categoryids;}
        }
        /// <summary>
        /// 首字母对应的编码ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 状态【0:禁用 1:启用】
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// 是否热词【0:非热词 1:热词】
        /// </summary>
        public Int32 IsHot
        {
            set{ _ishot=value;}
            get{return _ishot;}
        }
        /// <summary>
        /// 来源【系统生成、外来导入】
        /// </summary>
        public Int32 Source
        {
            set{ _source=value;}
            get{return _source;}
        }
        /// <summary>
        /// 搜索次数
        /// </summary>
        public decimal SearchNum
        {
            set{ _searchnum=value;}
            get{return _searchnum;}
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
        /// ToUrl
        /// </summary>
        public string ToUrl
        {
            set{ _tourl=value;}
            get{return _tourl;}
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
        /// 【类目ID】
        /// </summary>
        public Int32 TypeID
        {
            set{ _typeid=value;}
            get{return _typeid;}
        }
        /// <summary>
        /// 竞争度
        /// </summary>
        public string Competition
        {
            set{ _competition=value;}
            get{return _competition;}
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
        /// 【0:正常 1:生成过静态页 2:删除】
        /// </summary>
        public Int32 IsValueKey
        {
            set{ _isvaluekey=value;}
            get{return _isvaluekey;}
        }
        /// <summary>
        /// 分组ID
        /// </summary>
        public Int32 GroupID
        {
            set{ _groupid=value;}
            get{return _groupid;}
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
        /// SearchCount
        /// </summary>
        public Int32 SearchCount
        {
            set{ _searchcount=value;}
            get{return _searchcount;}
        }
        /// <summary>
        /// ComLevel
        /// </summary>
        public string ComLevel
        {
            set{ _comlevel=value;}
            get{return _comlevel;}
        }
        /// <summary>
        /// FirstWord
        /// </summary>
        public string FirstWord
        {
            set{ _firstword=value;}
            get{return _firstword;}
        }
        /// <summary>
        /// EnName
        /// </summary>
        public string EnName
        {
            set{ _enname=value;}
            get{return _enname;}
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
        /// SeoID
        /// </summary>
        public Int32 SeoID
        {
            set{ _seoid=value;}
            get{return _seoid;}
        }
        /// <summary>
        /// Style
        /// </summary>
        public Int32 Style
        {
            set{ _style=value;}
            get{return _style;}
        }
        /// <summary>
        /// BrandName
        /// </summary>
        public string BrandName
        {
            set{ _brandname=value;}
            get{return _brandname;}
        }
        #endregion
	}
}
