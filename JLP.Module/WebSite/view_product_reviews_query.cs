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
	public class view_product_reviews_query
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_reviews_query(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private DateTime _addtime = DateTime.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _content = null;
        private Int32 _usefulcount = Int32.MinValue;
        private string _leimuid = null;
        private decimal _level = decimal.MinValue;
        private string _useremail = null;
        private Int32 _pid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 评论添加时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        /// <summary>
        /// SPUID，外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
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
        /// 有用数
        /// </summary>
        public Int32 UseFulCount
        {
            set{ _usefulcount=value;}
            get{return _usefulcount;}
        }
        /// <summary>
        /// LeiMuID
        /// </summary>
        public string LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// Level
        /// </summary>
        public decimal Level
        {
            set{ _level=value;}
            get{return _level;}
        }
        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        public string UserEmail
        {
            set{ _useremail=value;}
            get{return _useremail;}
        }
        /// <summary>
        /// 产品URL的ID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        #endregion
	}
}
