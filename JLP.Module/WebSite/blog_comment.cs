/******************************************
* 模块名称：实体 博客评论表
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
	/// 实体 博客评论表
	/// </summary>
	[Description("Primary:Id")]
    [Serializable]
	public class blog_comment
	{
        #region 构造函数
        /// <summary>
        /// 实体 博客评论表
        /// </summary>
        public blog_comment(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _articleid = Int32.MinValue;
        private string _articletitle = null;
        private string _username = null;
        private string _useremail = null;
        private string _content = null;
        private Int32 _isshow = Int32.MinValue;
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
        /// 文章标题
        /// </summary>
        public string ArticleTitle
        {
            set{ _articletitle=value;}
            get{return _articletitle;}
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            set{ _username=value;}
            get{return _username;}
        }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserEmail
        {
            set{ _useremail=value;}
            get{return _useremail;}
        }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// 是否显示 1：显示    2：隐藏
        /// </summary>
        public Int32 IsShow
        {
            set{ _isshow=value;}
            get{return _isshow;}
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
