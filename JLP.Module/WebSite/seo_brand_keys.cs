/******************************************
* 模块名称：实体 seo_brand_keys
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
	/// 实体 seo_brand_keys
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_brand_keys
	{
        #region 构造函数
        /// <summary>
        /// 实体 seo_brand_keys
        /// </summary>
        public seo_brand_keys(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _keyname = null;
        private Int32 _siteid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private Int32 _state = Int32.MinValue;
        private Int32 _languageid = Int32.MinValue;
        private DateTime _finddate = DateTime.MinValue;
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
        /// KeyName
        /// </summary>
        public string KeyName
        {
            set{ _keyname=value;}
            get{return _keyname;}
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
        /// <summary>
        /// LanguageID
        /// </summary>
        public Int32 LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        /// <summary>
        /// FindDate
        /// </summary>
        public DateTime FindDate
        {
            set{ _finddate=value;}
            get{return _finddate;}
        }
        #endregion
	}
}
