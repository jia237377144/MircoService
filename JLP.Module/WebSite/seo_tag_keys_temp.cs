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
	public class seo_tag_keys_temp
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
        /// </summary>
        public seo_tag_keys_temp(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private string _categoryids = null;
        private Int32 _categoryid = Int32.MinValue;
        private string _descriptions = null;
        private Int32 _siteid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private Int32 _typeid = Int32.MinValue;
        private Int32 _groupid = Int32.MinValue;
        private string _title = null;
        private string _keywords = null;
        private string _description = null;
        private Int32 _searchcount = Int32.MinValue;
        private string _comlevel = null;
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
        /// 关键词名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// tag 字母【a、b、c】
        /// </summary>
        public string CategoryIDs
        {
            set{ _categoryids=value;}
            get{return _categoryids;}
        }
        /// <summary>
        /// 【tag字母对应的code值】
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// tag描述
        /// </summary>
        public string Descriptions
        {
            set{ _descriptions=value;}
            get{return _descriptions;}
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
        /// 【类目ID】
        /// </summary>
        public Int32 TypeID
        {
            set{ _typeid=value;}
            get{return _typeid;}
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
        #endregion
	}
}
