/******************************************
* 模块名称：实体 feed详细信息表
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
	/// 实体 feed详细信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class sem_feed_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 feed详细信息表
        /// </summary>
        public sem_feed_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _feedfilename = null;
        private Int32 _typeid = Int32.MinValue;
        private Int32 _googlecategoryid = Int32.MinValue;
        private string _googlecategorynames = null;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _languageid = Int32.MinValue;
        private string _productsize = null;
        private Int32 _adminid = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private string _gender = null;
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
        /// Feed文件名称
        /// </summary>
        public string FeedFileName
        {
            set{ _feedfilename=value;}
            get{return _feedfilename;}
        }
        /// <summary>
        /// 类别枚举，（文件=0、类目=1）
        /// </summary>
        public Int32 TypeID
        {
            set{ _typeid=value;}
            get{return _typeid;}
        }
        /// <summary>
        /// 谷哥类目ID
        /// </summary>
        public Int32 GoogleCategoryID
        {
            set{ _googlecategoryid=value;}
            get{return _googlecategoryid;}
        }
        /// <summary>
        /// 谷哥类目名称导航列表
        /// </summary>
        public string GoogleCategoryNames
        {
            set{ _googlecategorynames=value;}
            get{return _googlecategorynames;}
        }
        /// <summary>
        /// 站点ID，外键ID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// 网站类目ID
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 语言ID，外键ID
        /// </summary>
        public Int32 LanguageID
        {
            set{ _languageid=value;}
            get{return _languageid;}
        }
        /// <summary>
        /// 产品尺寸
        /// </summary>
        public string ProductSize
        {
            set{ _productsize=value;}
            get{return _productsize;}
        }
        /// <summary>
        /// 添加人ID，外键ID
        /// </summary>
        public Int32 AdminID
        {
            set{ _adminid=value;}
            get{return _adminid;}
        }
        /// <summary>
        /// 状态枚举，（可用=0、不可用=1）
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        /// <summary>
        /// Gender
        /// </summary>
        public string Gender
        {
            set{ _gender=value;}
            get{return _gender;}
        }
        #endregion
	}
}
