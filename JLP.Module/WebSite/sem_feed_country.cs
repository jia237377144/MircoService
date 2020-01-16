/******************************************
* 模块名称：实体 网站feed国家表
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
	/// 实体 网站feed国家表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class sem_feed_country
	{
        #region 构造函数
        /// <summary>
        /// 实体 网站feed国家表
        /// </summary>
        public sem_feed_country(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _countryid = Int32.MinValue;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _languageid = Int32.MinValue;
        private Int32 _adminid = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 国家ID，外键ID
        /// </summary>
        public Int32 CountryID
        {
            set{ _countryid=value;}
            get{return _countryid;}
        }
        /// <summary>
        /// 站点ID，外键ID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// 语言ID，外键ID
        /// </summary>
        public Int32 LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        /// <summary>
        /// 添加人ID，外键ID
        /// </summary>
        public Int32 AdminID
        {
            set{ _adminid=value;}
            get{return _adminid;}
        }
        /// <summary>
        /// 状态枚举，（可用=0、不可用=1）
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
        #endregion
	}
}
