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
	public class view_product_tab_name_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_tab_name_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _tabnameid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private string _categoryname = null;
        private string _categoryjson = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private Int32 _platform = Int32.MinValue;
        private string _tabcnname = null;
        private string _tabimagelogo = null;
        private string _tabculturename = null;
        private Int32 _tabstatus = Int32.MinValue;
        private string _content = null;
        private Int32 _cultureid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 选项卡标签ID，外键ID
        /// </summary>
        public Int32 TabNameID
        {
            set{ _tabnameid=value;}
            get{return _tabnameid;}
        }
        /// <summary>
        /// 所属品类ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 所属品类名称
        /// </summary>
        public string CategoryName
        {
            set{ _categoryname=value;}
            get{return _categoryname;}
        }
        /// <summary>
        /// 所属品类JSON
        /// </summary>
        public string CategoryJSON
        {
            set{ _categoryjson=value;}
            get{return _categoryjson;}
        }
        /// <summary>
        /// 状态（显示，隐藏）
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 排序值
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
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
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// Platform
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
        }
        /// <summary>
        /// 中文名称
        /// </summary>
        public string TabCNName
        {
            set{ _tabcnname=value;}
            get{return _tabcnname;}
        }
        /// <summary>
        /// 选项卡标签Logo
        /// </summary>
        public string TabImageLogo
        {
            set{ _tabimagelogo=value;}
            get{return _tabimagelogo;}
        }
        /// <summary>
        /// 多语言名称
        /// </summary>
        public string TabCultureName
        {
            set{ _tabculturename=value;}
            get{return _tabculturename;}
        }
        /// <summary>
        /// 状态（弃用，禁用）
        /// </summary>
        public Int32 TabStatus
        {
            set{ _tabstatus=value;}
            get{return _tabstatus;}
        }
        /// <summary>
        /// 多语言内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// 多语言ID，外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        #endregion
	}
}
