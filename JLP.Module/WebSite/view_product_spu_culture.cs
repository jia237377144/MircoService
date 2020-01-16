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
	public class view_product_spu_culture
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_culture(){}
        #endregion

        #region 私有变量
        private Int32 _spuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _title = null;
        private string _descriptionimagetext = null;
        private string _descriptionfull = null;
        private string _descriptionshort = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// SPU ID (外键)
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 语言ID(外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
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
        /// DescriptionImageText
        /// </summary>
        public string DescriptionImageText
        {
            set{ _descriptionimagetext=value;}
            get{return _descriptionimagetext;}
        }
        /// <summary>
        /// DescriptionFull
        /// </summary>
        public string DescriptionFull
        {
            set{ _descriptionfull=value;}
            get{return _descriptionfull;}
        }
        /// <summary>
        /// DescriptionShort
        /// </summary>
        public string DescriptionShort
        {
            set{ _descriptionshort=value;}
            get{return _descriptionshort;}
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
        #endregion
	}
}
