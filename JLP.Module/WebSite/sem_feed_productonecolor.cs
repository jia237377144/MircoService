/******************************************
* 模块名称：实体 sem_feed_productonecolor
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
	/// 实体 sem_feed_productonecolor
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class sem_feed_productonecolor
	{
        #region 构造函数
        /// <summary>
        /// 实体 sem_feed_productonecolor
        /// </summary>
        public sem_feed_productonecolor(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _productid = Int32.MinValue;
        private string _color = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// ProductId
        /// </summary>
        public Int32 ProductId
        {
            set{ _productid=value;}
            get{return _productid;}
        }
        /// <summary>
        /// Color
        /// </summary>
        public string Color
        {
            set{ _color=value;}
            get{return _color;}
        }
        #endregion
	}
}
