/******************************************
* 模块名称：实体 sem_option_mapping
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
	/// 实体 sem_option_mapping
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class sem_option_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 sem_option_mapping
        /// </summary>
        public sem_option_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _requirevalueid = Int32.MinValue;
        private Int32 _optionvalid = Int32.MinValue;
        private string _text = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// requirevalueid
        /// </summary>
        public Int32 requirevalueid
        {
            set{ _requirevalueid=value;}
            get{return _requirevalueid;}
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
        /// text
        /// </summary>
        public string text
        {
            set{ _text=value;}
            get{return _text;}
        }
        #endregion
	}
}
