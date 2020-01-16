/******************************************
* 模块名称：实体 SEO-类目描述多语言表
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
	/// 实体 SEO-类目描述多语言表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_leimu_culture
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO-类目描述多语言表
        /// </summary>
        public seo_leimu_culture(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private string _pagedescription = null;
        private string _metatitle = null;
        private string _metakeywords = null;
        private string _metadescription = null;
        private string _leimudescription = null;
        private string _url = null;
        private Int32 _cultureid = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
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
        /// 类目ID,外键ID
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 类目描述(在页面显示)
        /// </summary>
        public string PageDescription
        {
            set{ _pagedescription=value;}
            get{return _pagedescription;}
        }
        /// <summary>
        /// 类目Meta标题
        /// </summary>
        public string MetaTitle
        {
            set{ _metatitle=value;}
            get{return _metatitle;}
        }
        /// <summary>
        /// 类目Meta关键词
        /// </summary>
        public string MetaKeywords
        {
            set{ _metakeywords=value;}
            get{return _metakeywords;}
        }
        /// <summary>
        /// 类目Meta描述
        /// </summary>
        public string MetaDescription
        {
            set{ _metadescription=value;}
            get{return _metadescription;}
        }
        /// <summary>
        /// 类目多语言描述信息
        /// </summary>
        public string LeiMuDescription
        {
            set{ _leimudescription=value;}
            get{return _leimudescription;}
        }
        /// <summary>
        /// 类目显示的URL，数据库存放的是绝对路径
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 语言ID ,外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// CreateUserName
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
