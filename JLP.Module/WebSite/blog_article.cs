/******************************************
* 模块名称：实体 博客文章表
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
	/// 实体 博客文章表
	/// </summary>
	[Description("Primary:Id")]
    [Serializable]
	public class blog_article
	{
        #region 构造函数
        /// <summary>
        /// 实体 博客文章表
        /// </summary>
        public blog_article(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _istop = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private string _author = null;
        private Int32 _categoryid = Int32.MinValue;
        private string _pids = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID(NOT NULL)
        /// </summary>
        public Int32 Id
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public Int32 IsTop
        {
            set{ _istop=value;}
            get{return _istop;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author
        {
            set{ _author=value;}
            get{return _author;}
        }
        /// <summary>
        /// 所属类别(外键)
        /// </summary>
        public Int32 CategoryId
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 关联的产品
        /// </summary>
        public string PIDS
        {
            set{ _pids=value;}
            get{return _pids;}
        }
        #endregion
	}
}
