/******************************************
* 模块名称：实体 Feed运费
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
	/// 实体 Feed运费
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class sem_feed_shipping
	{
        #region 构造函数
        /// <summary>
        /// 实体 Feed运费
        /// </summary>
        public sem_feed_shipping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _countryid = Int32.MinValue;
        private Int32 _languageid = Int32.MinValue;
        private decimal _price = decimal.MinValue;
        private string _service = null;
        private DateTime _adddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
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
        /// 多语言ID，外键ID
        /// </summary>
        public Int32 LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        /// <summary>
        /// 运费
        /// </summary>
        public decimal Price
        {
            set{ _price=value;}
            get{return _price;}
        }
        /// <summary>
        /// 运输方式
        /// </summary>
        public string Service
        {
            set{ _service=value;}
            get{return _service;}
        }
        /// <summary>
        /// AddDate
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        #endregion
	}
}
