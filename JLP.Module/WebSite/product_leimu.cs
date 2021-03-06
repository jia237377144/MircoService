﻿/******************************************
* 模块名称：实体 网站类目表
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
	/// 实体 网站类目表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_leimu
	{
        #region 构造函数
        /// <summary>
        /// 实体 网站类目表
        /// </summary>
        public product_leimu(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private string _urlname = null;
        private string _description = null;
        private Int32 _parentid = Int32.MinValue;
        private string _imagejson = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _isshow = Int32.MinValue;
        private string _pricerangejson = null;
        private Int32 _status = Int32.MinValue;
        private string _pcredirecturl = null;
        private string _mredirecturl = null;
        private string _appredircturl = null;
        private Int32 _showstyle = Int32.MinValue;
        private Int32 _type = Int32.MinValue;
        private string _url = null;
        private string _platformjson = null;
        private string _sitename = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
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
        /// 地址栏类目显示名称(只存类目的英文名称)
        /// </summary>
        public string UrlName
        {
            set{ _urlname=value;}
            get{return _urlname;}
        }
        /// <summary>
        /// 中文描述
        /// </summary>
        public string Description
        {
            set{ _description=value;}
            get{return _description;}
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
        /// 枚举：显示，隐藏，删除
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 类目状态隐藏式需要跳转到此URL
        /// </summary>
        public string PCRedirectUrl
        {
            set{ _pcredirecturl=value;}
            get{return _pcredirecturl;}
        }
        /// <summary>
        /// MRedirectUrl
        /// </summary>
        public string MRedirectUrl
        {
            set{ _mredirecturl=value;}
            get{return _mredirecturl;}
        }
        /// <summary>
        /// 类目状态隐藏时需要跳转到此URL APP用
        /// </summary>
        public string APPRedirctUrl
        {
            set{ _appredircturl=value;}
            get{return _appredircturl;}
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
        #endregion
	}
}
