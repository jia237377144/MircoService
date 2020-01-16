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
	public class view_product_requiredvalue
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_requiredvalue(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _requiredkeyid = Int32.MinValue;
        private string _urltext = null;
        private string _webvaluename = null;
        private string _image = null;
        private string _icon = null;
        private string _value = null;
        private Int32 _isenable = Int32.MinValue;
        private Int32 _requiredvalue_culturepartid = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
        private Int32 _cultureid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 必选区键ID，外键
        /// </summary>
        public Int32 RequiredKeyID
        {
            set{ _requiredkeyid=value;}
            get{return _requiredkeyid;}
        }
        /// <summary>
        /// UrlText
        /// </summary>
        public string UrlText
        {
            set{ _urltext=value;}
            get{return _urltext;}
        }
        /// <summary>
        /// WebValueName
        /// </summary>
        public string WebValueName
        {
            set{ _webvaluename=value;}
            get{return _webvaluename;}
        }
        /// <summary>
        /// 必选区自定制图片Src
        /// </summary>
        public string Image
        {
            set{ _image=value;}
            get{return _image;}
        }
        /// <summary>
        /// 必选区自定制色块Src
        /// </summary>
        public string Icon
        {
            set{ _icon=value;}
            get{return _icon;}
        }
        /// <summary>
        /// 必选区值
        /// </summary>
        public string Value
        {
            set{ _value=value;}
            get{return _value;}
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public Int32 IsEnable
        {
            set{ _isenable=value;}
            get{return _isenable;}
        }
        /// <summary>
        /// 自增ID(NOT NULL)
        /// </summary>
        public Int32 RequiredValue_CulturePartID
        {
            set{ _requiredvalue_culturepartid=value;}
            get{return _requiredvalue_culturepartid;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
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
        /// 语言ID (外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        #endregion
	}
}
