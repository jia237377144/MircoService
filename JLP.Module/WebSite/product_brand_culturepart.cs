/******************************************
* 模块名称：实体 品牌多语言
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
	/// 实体 品牌多语言
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_brand_culturepart
	{
        #region 构造函数
        /// <summary>
        /// 实体 品牌多语言
        /// </summary>
        public product_brand_culturepart(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _brandid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _description = null;
        private string _story = null;
        private string _history = null;
        private string _designconcept = null;
        private string _team = null;
        private string _brandstoryurl = null;
        private string _brandlogourl = null;
        private string _sort = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID，自增(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 品牌ID，外键ID
        /// </summary>
        public Int32 BrandID
        {
            set{ _brandid=value;}
            get{return _brandid;}
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
        /// 描述
        /// </summary>
        public string Description
        {
            set{ _description=value;}
            get{return _description;}
        }
        /// <summary>
        /// 故事
        /// </summary>
        public string Story
        {
            set{ _story=value;}
            get{return _story;}
        }
        /// <summary>
        /// 发展史
        /// </summary>
        public string History
        {
            set{ _history=value;}
            get{return _history;}
        }
        /// <summary>
        /// 设计理念
        /// </summary>
        public string DesignConcept
        {
            set{ _designconcept=value;}
            get{return _designconcept;}
        }
        /// <summary>
        /// 团队介绍
        /// </summary>
        public string Team
        {
            set{ _team=value;}
            get{return _team;}
        }
        /// <summary>
        /// 品牌故事页链接
        /// </summary>
        public string BrandStoryUrl
        {
            set{ _brandstoryurl=value;}
            get{return _brandstoryurl;}
        }
        /// <summary>
        /// 品牌logo链接
        /// </summary>
        public string BrandLogoUrl
        {
            set{ _brandlogourl=value;}
            get{return _brandlogourl;}
        }
        /// <summary>
        /// 排序
        /// </summary>
        public string Sort
        {
            set{ _sort=value;}
            get{return _sort;}
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
