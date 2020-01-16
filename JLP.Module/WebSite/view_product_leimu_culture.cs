/******************************************
* 模块名称：实体 VIEW
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
	/// 实体 VIEW
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class view_product_leimu_culture
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_leimu_culture(){}
        #endregion

        #region 私有变量
        private Int32 _leimuid = Int32.MinValue;
        private string _name = null;
        private Int32 _cultureid = Int32.MinValue;
        private string _culturename = null;
        private string _culturedescription = null;
        private string _urlname = null;
        private Int32 _parentid = Int32.MinValue;
        private string _imagejson = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _isshow = Int32.MinValue;
        private string _pricerangejson = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _type = Int32.MinValue;
        private string _url = null;
        private Int32 _showstyle = Int32.MinValue;
        private string _platformjson = null;
        private string _sitename = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        private string _pcredirecturl = null;
        private string _mredirecturl = null;
        private string _appredircturl = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 自增ID(NOT NULL)
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 中文名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 语言ID (外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// CultureName
        /// </summary>
        public string CultureName
        {
            set{ _culturename=value;}
            get{return _culturename;}
        }
        /// <summary>
        /// CultureDescription
        /// </summary>
        public string CultureDescription
        {
            set{ _culturedescription=value;}
            get{return _culturedescription;}
        }
        /// <summary>
        /// 地址栏类目显示名称(只存类目的英文名称)
        /// </summary>
        public string UrlName
        {
            set{ _urlname=value;}
            get{return _urlname;}
        }
        /// <summary>
        /// 直接父级ID
        /// </summary>
        public Int32 ParentID
        {
            set{ _parentid=value;}
            get{return _parentid;}
        }
        /// <summary>
        /// 类目显示用的URL地址JSON
        /// </summary>
        public string ImageJSON
        {
            set{ _imagejson=value;}
            get{return _imagejson;}
        }
        /// <summary>
        /// 排序
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 枚举：是否显示在网站上面，左面
        /// </summary>
        public Int32 IsShow
        {
            set{ _isshow=value;}
            get{return _isshow;}
        }
        /// <summary>
        /// 类目筛选价格区间JSON。{status:1,note:'',range:[{begin:100,end:200,sort:1},{begin:200,end:300,sort:2}]}
        /// </summary>
        public string PriceRangeJSON
        {
            set{ _pricerangejson=value;}
            get{return _pricerangejson;}
        }
        /// <summary>
        /// 类目多语言状态EStatus枚举
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 类目类型枚举，（活动，产品，专题）
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 显示URL
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 类目下的产品图片显示比例   枚举 ELeimuProductShowStyle
        /// </summary>
        public Int32 ShowStyle
        {
            set{ _showstyle=value;}
            get{return _showstyle;}
        }
        /// <summary>
        /// 枚举:类目显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 类目显示在指定的网站下面，为空显示在默认名下面
        /// </summary>
        public string SiteName
        {
            set{ _sitename=value;}
            get{return _sitename;}
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
        /// <summary>
        /// 支持多语言，类目状态隐藏式需要跳转到此URL PC用
        /// </summary>
        public string PCRedirectUrl
        {
            set{ _pcredirecturl=value;}
            get{return _pcredirecturl;}
        }
        /// <summary>
        /// 支持多语言，类目状态隐藏式需要跳转到此URL M用
        /// </summary>
        public string MRedirectUrl
        {
            set{ _mredirecturl=value;}
            get{return _mredirecturl;}
        }
        /// <summary>
        /// 支持多语言，类目状态隐藏式需要跳转到此URL APP用
        /// </summary>
        public string APPRedirctUrl
        {
            set{ _appredircturl=value;}
            get{return _appredircturl;}
        }
        #endregion
	}
}
