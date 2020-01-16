/******************************************
* 模块名称：实体 文章多语言表
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
	/// 实体 文章多语言表
	/// </summary>
	[Description("Primary:Id")]
    [Serializable]
	public class blog_article_culturepart
	{
        #region 构造函数
        /// <summary>
        /// 实体 文章多语言表
        /// </summary>
        public blog_article_culturepart(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _articleid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _title = null;
        private string _content = null;
        private string _remark = null;
        private DateTime _createtime = DateTime.MinValue;
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
        /// 文章ID
        /// </summary>
        public Int32 ArticleId
        {
            set{ _articleid=value;}
            get{return _articleid;}
        }
        /// <summary>
        /// 语言ID
        /// </summary>
        public Int32 CultureId
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
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
        /// 文章内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
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
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        #endregion
	}
}
