/******************************************
* 模块名称：实体 topic_newin_click
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
	/// 实体 topic_newin_click
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_newin_click
	{
        #region 构造函数
        /// <summary>
        /// 实体 topic_newin_click
        /// </summary>
        public topic_newin_click(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topicnewinid = Int32.MinValue;
        private Int32 _visitcount = Int32.MinValue;
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
        /// TopicNewInID
        /// </summary>
        public Int32 TopicNewInID
        {
            set{ _topicnewinid=value;}
            get{return _topicnewinid;}
        }
        /// <summary>
        /// VisitCount
        /// </summary>
        public Int32 VisitCount
        {
            set{ _visitcount=value;}
            get{return _visitcount;}
        }
        #endregion
	}
}
