/******************************************
* 模块名称：实体 sem_feed_oldsite_required
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
	/// 实体 sem_feed_oldsite_required
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class sem_feed_oldsite_required
	{
        #region 构造函数
        /// <summary>
        /// 实体 sem_feed_oldsite_required
        /// </summary>
        public sem_feed_oldsite_required(){}
        #endregion

        #region 私有变量
        private Int32 _productid = Int32.MinValue;
        private Int32 _optiontype = Int32.MinValue;
        private Int32 _optionvalid = Int32.MinValue;
        private string _optionval = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// productid
        /// </summary>
        public Int32 productid
        {
            set{ _productid=value;}
            get{return _productid;}
        }
        /// <summary>
        /// 1:颜色；2：尺寸
        /// </summary>
        public Int32 optiontype
        {
            set{ _optiontype=value;}
            get{return _optiontype;}
        }
        /// <summary>
        /// optionvalid
        /// </summary>
        public Int32 optionvalid
        {
            set{ _optionvalid=value;}
            get{return _optionvalid;}
        }
        /// <summary>
        /// optionval
        /// </summary>
        public string optionval
        {
            set{ _optionval=value;}
            get{return _optionval;}
        }
        #endregion
	}
}
