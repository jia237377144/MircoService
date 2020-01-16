/******************************************
* 模块名称：实体 网站信息多语言表
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
	/// 实体 网站信息多语言表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class website_culture
	{
        #region 构造函数
        /// <summary>
        /// 实体 网站信息多语言表
        /// </summary>
        public website_culture(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _parentcultureid = Int32.MinValue;
        private string _text = null;
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
        /// 多语言ID，外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 从哪个语言转过来的多语言文本信息
        /// </summary>
        public Int32 ParentCultureID
        {
            set{ _parentcultureid=value;}
            get{return _parentcultureid;}
        }
        /// <summary>
        /// 多语言文本
        /// </summary>
        public string Text
        {
            set{ _text=value;}
            get{return _text;}
        }
        #endregion
	}
}
