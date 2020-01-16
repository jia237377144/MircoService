/******************************************
* 模块名称：实体 SPU和必选区值关系修改表
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
	/// 实体 SPU和必选区值关系修改表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_requiredvalue_modify
	{
        #region 构造函数
        /// <summary>
        /// 实体 SPU和必选区值关系修改表
        /// </summary>
        public product_spu_requiredvalue_modify(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _requiredvalueid = Int32.MinValue;
        private string _image = null;
        private string _images = null;
        private string _icon = null;
        private decimal _increaseprice = decimal.MinValue;
        private Int32 _sort = Int32.MinValue;
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
        /// PMS传过来的ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 必选区值ID
        /// </summary>
        public Int32 RequiredValueID
        {
            set{ _requiredvalueid=value;}
            get{return _requiredvalueid;}
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
        /// Images
        /// </summary>
        public string Images
        {
            set{ _images=value;}
            get{return _images;}
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
        /// 必选区值加价
        /// </summary>
        public decimal IncreasePrice
        {
            set{ _increaseprice=value;}
            get{return _increaseprice;}
        }
        /// <summary>
        /// 必选区值排序
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
        #endregion
	}
}
