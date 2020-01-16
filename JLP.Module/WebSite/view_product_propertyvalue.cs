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
	public class view_product_propertyvalue
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_propertyvalue(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _propertykeyid = Int32.MinValue;
        private string _chinesevaluename = null;
        private string _urltext = null;
        private string _webvaluename = null;
        private string _pmsvaluename = null;
        private string _chinesekeyname = null;
        private Int32 _status = Int32.MinValue;
        private string _remark = null;
        private Int32 _propertyvalue_culturepartid = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
        private string _pmsremark = null;
        private Int32 _cultureid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 属性KEY ID (外键)
        /// </summary>
        public Int32 PropertyKeyID
        {
            set{ _propertykeyid=value;}
            get{return _propertykeyid;}
        }
        /// <summary>
        /// 必选区值
        /// </summary>
        public string ChineseValueName
        {
            set{ _chinesevaluename=value;}
            get{return _chinesevaluename;}
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
        /// 属性值的显示文本
        /// </summary>
        public string PMSValueName
        {
            set{ _pmsvaluename=value;}
            get{return _pmsvaluename;}
        }
        /// <summary>
        /// KEY 的名称
        /// </summary>
        public string ChineseKeyName
        {
            set{ _chinesekeyname=value;}
            get{return _chinesekeyname;}
        }
        /// <summary>
        /// 枚举，显示，不显示
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set{ _remark=value;}
            get{return _remark;}
        }
        /// <summary>
        /// 自增ID(NOT NULL)
        /// </summary>
        public Int32 PropertyValue_CulturePartID
        {
            set{ _propertyvalue_culturepartid=value;}
            get{return _propertyvalue_culturepartid;}
        }
        /// <summary>
        /// 备注
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
        /// 备注
        /// </summary>
        public string PMSRemark
        {
            set{ _pmsremark=value;}
            get{return _pmsremark;}
        }
        /// <summary>
        /// 语言ID(外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        #endregion
	}
}
