/******************************************
* 模块名称：实体 SPU修改信息多语言部分
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
	/// 实体 SPU修改信息多语言部分
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_culturepart_modify
	{
        #region 构造函数
        /// <summary>
        /// 实体 SPU修改信息多语言部分
        /// </summary>
        public product_spu_culturepart_modify(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _title = null;
        private string _descriptionfull = null;
        private string _descriptionshort = null;
        private string _descriptionimagetext = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _render = Int32.MinValue;
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
        /// SPU外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// CultureID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 多语言标题
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 多语言详细描述
        /// </summary>
        public string DescriptionFull
        {
            set{ _descriptionfull=value;}
            get{return _descriptionfull;}
        }
        /// <summary>
        /// 多语言短描述
        /// </summary>
        public string DescriptionShort
        {
            set{ _descriptionshort=value;}
            get{return _descriptionshort;}
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
        /// 多语言排序
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 多语言显示状态(显示=1，隐藏=0)
        /// </summary>
        public Int32 Render
        {
            set{ _render=value;}
            get{return _render;}
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
