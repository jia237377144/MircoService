/******************************************
* 模块名称：实体 专题模板
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
	/// 实体 专题模板
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_template
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题模板
        /// </summary>
        public topic_template(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private string _url = null;
        private Int32 _pagetype = Int32.MinValue;
        private string _pageurl = null;
        private string _pagemurl = null;
        private string _pageappurl = null;
        private string _thumburl = null;
        private string _platformjson = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private string _lastupdatecontent = null;
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
        /// 模板名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 模板URL
        /// </summary>
        public string Url
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 模板类型（1:可复用专题、0:非复用专题）
        /// </summary>
        public Int32 PageType
        {
            set{ _pagetype=value;}
            get{return _pagetype;}
        }
        /// <summary>
        /// 前端生成静态页面地址URL
        /// </summary>
        public string PageUrl
        {
            set{ _pageurl=value;}
            get{return _pageurl;}
        }
        /// <summary>
        /// 前端生成静态页面地址M站URL
        /// </summary>
        public string PageMUrl
        {
            set{ _pagemurl=value;}
            get{return _pagemurl;}
        }
        /// <summary>
        /// 前端生成静态页面地址App站URL
        /// </summary>
        public string PageAppUrl
        {
            set{ _pageappurl=value;}
            get{return _pageappurl;}
        }
        /// <summary>
        /// 缩略图URL
        /// </summary>
        public string ThumbUrl
        {
            set{ _thumburl=value;}
            get{return _thumburl;}
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
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 排序编号
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
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
