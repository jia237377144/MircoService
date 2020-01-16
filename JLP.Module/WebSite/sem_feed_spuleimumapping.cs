/******************************************
* 模块名称：实体 sem_feed_spuleimumapping
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
	/// 实体 sem_feed_spuleimumapping
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class sem_feed_spuleimumapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 sem_feed_spuleimumapping
        /// </summary>
        public sem_feed_spuleimumapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
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
        /// SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// LeimuID
        /// </summary>
        public Int32 LeimuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// AddDate
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        #endregion
	}
}
