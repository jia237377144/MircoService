/******************************************
* 模块名称：实体 产品SPU——多语言部分
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
	/// 实体 产品SPU——多语言部分
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_culturepart
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品SPU——多语言部分
        /// </summary>
        public product_spu_culturepart(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _title = null;
        private string _descriptionfull = null;
        private string _descriptionshort = null;
        private string _descriptionimagetext = null;
        private string _keys = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// 语言ID(外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// SPU ID (外键)
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 详细描述
        /// </summary>
        public string DescriptionFull
        {
            set{ _descriptionfull=value;}
            get{return _descriptionfull;}
        }
        /// <summary>
        /// 短描述
        /// </summary>
        public string DescriptionShort
        {
            set{ _descriptionshort=value;}
            get{return _descriptionshort;}
        }
        /// <summary>
        /// 新增图文描述对接PMS详细描述
        /// </summary>
        public string DescriptionImageText
        {
            set{ _descriptionimagetext=value;}
            get{return _descriptionimagetext;}
        }
        /// <summary>
        /// 搜索关键词
        /// </summary>
        public string Keys
        {
            set{ _keys=value;}
            get{return _keys;}
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
