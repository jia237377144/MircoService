/******************************************
* 模块名称：实体 seo_tag_category
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
	/// 实体 seo_tag_category
	/// </summary>
	[Description("Primary:ID,SiteID")]
    [Serializable]
	public class seo_tag_category
	{
        #region 构造函数
        /// <summary>
        /// 实体 seo_tag_category
        /// </summary>
        public seo_tag_category(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _parentid = Int32.MinValue;
        private string _name = null;
        private string _cnname = null;
        private Int32 _productcount = Int32.MinValue;
        private string _parentids = null;
        private Int32 _sort = Int32.MinValue;
        private string _logo = null;
        private Int32 _showtype = Int32.MinValue;
        private Int32 _fakelevel = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private Int32 _siteid = Int32.MinValue;
        private string _titletags = null;
        private string _keywordstags = null;
        private string _descriptiontags = null;
        private string _description = null;
        private decimal _customprice = decimal.MinValue;
        private Int32 _productcount1 = Int32.MinValue;
        private Int32 _categorynameid = Int32.MinValue;
        private byte[] _isshow = null;
        private string _defaulturl = null;
        private string _firstword = null;
        private Int32 _imagewidth = Int32.MinValue;
        private Int32 _imageheight = Int32.MinValue;
        private Int32 _imagequality = Int32.MinValue;
        private Int32 _isusercustomimage = Int32.MinValue;
        private string _redirecturl = null;
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
        /// ParentID
        /// </summary>
        public Int32 ParentID
        {
            set{ _parentid=value;}
            get{return _parentid;}
        }
        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// CNName
        /// </summary>
        public string CNName
        {
            set{ _cnname=value;}
            get{return _cnname;}
        }
        /// <summary>
        /// ProductCount
        /// </summary>
        public Int32 ProductCount
        {
            set{ _productcount=value;}
            get{return _productcount;}
        }
        /// <summary>
        /// ParentIDs
        /// </summary>
        public string ParentIDs
        {
            set{ _parentids=value;}
            get{return _parentids;}
        }
        /// <summary>
        /// Sort
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// Logo
        /// </summary>
        public string Logo
        {
            set{ _logo=value;}
            get{return _logo;}
        }
        /// <summary>
        /// ShowType
        /// </summary>
        public Int32 ShowType
        {
            set{ _showtype=value;}
            get{return _showtype;}
        }
        /// <summary>
        /// FakeLevel
        /// </summary>
        public Int32 FakeLevel
        {
            set{ _fakelevel=value;}
            get{return _fakelevel;}
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
        /// 主键 SiteID(NOT NULL)
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// TitleTags
        /// </summary>
        public string TitleTags
        {
            set{ _titletags=value;}
            get{return _titletags;}
        }
        /// <summary>
        /// KeywordsTags
        /// </summary>
        public string KeywordsTags
        {
            set{ _keywordstags=value;}
            get{return _keywordstags;}
        }
        /// <summary>
        /// DescriptionTags
        /// </summary>
        public string DescriptionTags
        {
            set{ _descriptiontags=value;}
            get{return _descriptiontags;}
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
        /// CustomPrice
        /// </summary>
        public decimal CustomPrice
        {
            set{ _customprice=value;}
            get{return _customprice;}
        }
        /// <summary>
        /// ProductCount1
        /// </summary>
        public Int32 ProductCount1
        {
            set{ _productcount1=value;}
            get{return _productcount1;}
        }
        /// <summary>
        /// CategoryNameID
        /// </summary>
        public Int32 CategoryNameID
        {
            set{ _categorynameid=value;}
            get{return _categorynameid;}
        }
        /// <summary>
        /// IsShow
        /// </summary>
        public byte[] IsShow
        {
            set{ _isshow=value;}
            get{return _isshow;}
        }
        /// <summary>
        /// defaultUrl
        /// </summary>
        public string defaultUrl
        {
            set{ _defaulturl=value;}
            get{return _defaulturl;}
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
        /// ImageWidth
        /// </summary>
        public Int32 ImageWidth
        {
            set{ _imagewidth=value;}
            get{return _imagewidth;}
        }
        /// <summary>
        /// ImageHeight
        /// </summary>
        public Int32 ImageHeight
        {
            set{ _imageheight=value;}
            get{return _imageheight;}
        }
        /// <summary>
        /// ImageQuality
        /// </summary>
        public Int32 ImageQuality
        {
            set{ _imagequality=value;}
            get{return _imagequality;}
        }
        /// <summary>
        /// IsUserCustomImage
        /// </summary>
        public Int32 IsUserCustomImage
        {
            set{ _isusercustomimage=value;}
            get{return _isusercustomimage;}
        }
        /// <summary>
        /// RedirectUrl
        /// </summary>
        public string RedirectUrl
        {
            set{ _redirecturl=value;}
            get{return _redirecturl;}
        }
        #endregion
	}
}
