/******************************************
* 模块名称：实体 专题信息表
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
	/// 实体 专题信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题信息表
        /// </summary>
        public topic_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private Int32 _groupid = Int32.MinValue;
        private Int32 _deptid = Int32.MinValue;
        private string _templatepath = null;
        private string _adverthrefpath = null;
        private string _urldomain = null;
        private string _urlpath = null;
        private string _urlroute = null;
        private Int32 _isuseroute = Int32.MinValue;
        private Int32 _isgenerate = Int32.MinValue;
        private string _backgroundcolor = null;
        private string _enname = null;
        private string _keywords = null;
        private string _topicleimuids = null;
        private string _platformjson = null;
        private Int32 _templateid = Int32.MinValue;
        private Int32 _ismulticulture = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _lastupdatecontent = null;
        private Int32 _viewcount = Int32.MinValue;
        private Int32 _sharecount = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
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
        /// 专题名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 专题组ID，自增ID
        /// </summary>
        public Int32 GroupID
        {
            set{ _groupid=value;}
            get{return _groupid;}
        }
        /// <summary>
        /// 部门ID，自增ID
        /// </summary>
        public Int32 DeptID
        {
            set{ _deptid=value;}
            get{return _deptid;}
        }
        /// <summary>
        /// 模版路径
        /// </summary>
        public string TemplatePath
        {
            set{ _templatepath=value;}
            get{return _templatepath;}
        }
        /// <summary>
        /// 模板页面打开的广告路径
        /// </summary>
        public string AdvertHrefPath
        {
            set{ _adverthrefpath=value;}
            get{return _adverthrefpath;}
        }
        /// <summary>
        /// 专题的域名
        /// </summary>
        public string UrlDomain
        {
            set{ _urldomain=value;}
            get{return _urldomain;}
        }
        /// <summary>
        /// 专题的域名后面跟的路径名称
        /// </summary>
        public string UrlPath
        {
            set{ _urlpath=value;}
            get{return _urlpath;}
        }
        /// <summary>
        /// UrlRoute
        /// </summary>
        public string UrlRoute
        {
            set{ _urlroute=value;}
            get{return _urlroute;}
        }
        /// <summary>
        /// IsUseRoute
        /// </summary>
        public Int32 IsUseRoute
        {
            set{ _isuseroute=value;}
            get{return _isuseroute;}
        }
        /// <summary>
        /// 是否生成静态页面枚举类型：(0:否 1:是)
        /// </summary>
        public Int32 IsGenerate
        {
            set{ _isgenerate=value;}
            get{return _isgenerate;}
        }
        /// <summary>
        /// 专题背景颜色，供前端使用
        /// </summary>
        public string BackgroundColor
        {
            set{ _backgroundcolor=value;}
            get{return _backgroundcolor;}
        }
        /// <summary>
        /// 专题英文名
        /// </summary>
        public string EnName
        {
            set{ _enname=value;}
            get{return _enname;}
        }
        /// <summary>
        /// 专题相关关键词
        /// </summary>
        public string KeyWords
        {
            set{ _keywords=value;}
            get{return _keywords;}
        }
        /// <summary>
        /// 专题相关类目ID,逗号分割
        /// </summary>
        public string TopicLeiMuIDs
        {
            set{ _topicleimuids=value;}
            get{return _topicleimuids;}
        }
        /// <summary>
        /// 适用平台
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 模板ID，外键ID
        /// </summary>
        public Int32 TemplateID
        {
            set{ _templateid=value;}
            get{return _templateid;}
        }
        /// <summary>
        /// 是否支持多语言
        /// </summary>
        public Int32 IsMultiCulture
        {
            set{ _ismulticulture=value;}
            get{return _ismulticulture;}
        }
        /// <summary>
        /// Status
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 最后一个编辑人的修改内容
        /// </summary>
        public string LastUpdateContent
        {
            set{ _lastupdatecontent=value;}
            get{return _lastupdatecontent;}
        }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public Int32 ViewCount
        {
            set{ _viewcount=value;}
            get{return _viewcount;}
        }
        /// <summary>
        /// 分享次数
        /// </summary>
        public Int32 ShareCount
        {
            set{ _sharecount=value;}
            get{return _sharecount;}
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
