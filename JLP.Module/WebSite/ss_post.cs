/******************************************
* 模块名称：实体 买家秀信息
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
	/// 实体 买家秀信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class ss_post
	{
        #region 构造函数
        /// <summary>
        /// 实体 买家秀信息
        /// </summary>
        public ss_post(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _title = null;
        private Int32 _parentid = Int32.MinValue;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private string _images = null;
        private Int32 _userid = Int32.MinValue;
        private string _pid = null;
        private Int32 _categoryid = Int32.MinValue;
        private string _tagsid = null;
        private string _descriptions = null;
        private string _height = null;
        private string _weights = null;
        private string _size = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// Title
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
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
        /// SiteID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
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
        /// Images
        /// </summary>
        public string Images
        {
            set{ _images=value;}
            get{return _images;}
        }
        /// <summary>
        /// UserID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// PID
        /// </summary>
        public string PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// CategoryID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// TagsID
        /// </summary>
        public string TagsID
        {
            set{ _tagsid=value;}
            get{return _tagsid;}
        }
        /// <summary>
        /// Descriptions
        /// </summary>
        public string Descriptions
        {
            set{ _descriptions=value;}
            get{return _descriptions;}
        }
        /// <summary>
        /// Height
        /// </summary>
        public string Height
        {
            set{ _height=value;}
            get{return _height;}
        }
        /// <summary>
        /// Weights
        /// </summary>
        public string Weights
        {
            set{ _weights=value;}
            get{return _weights;}
        }
        /// <summary>
        /// Size
        /// </summary>
        public string Size
        {
            set{ _size=value;}
            get{return _size;}
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
        #endregion
	}
}
