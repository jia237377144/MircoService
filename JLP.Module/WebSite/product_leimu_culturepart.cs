/******************************************
* 模块名称：实体 类目多语言
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
	/// 实体 类目多语言
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_leimu_culturepart
	{
        #region 构造函数
        /// <summary>
        /// 实体 类目多语言
        /// </summary>
        public product_leimu_culturepart(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _name = null;
        private string _description = null;
        private string _pcredirecturl = null;
        private string _mredirecturl = null;
        private string _appredircturl = null;
        private Int32 _status = Int32.MinValue;
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
        /// 类目ID，外键
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
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
        /// 多语言的类目名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 多语言的类目描述
        /// </summary>
        public string Description
        {
            set{ _description=value;}
            get{return _description;}
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
        /// <summary>
        /// 类目多语言状态EStatus枚举
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
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
