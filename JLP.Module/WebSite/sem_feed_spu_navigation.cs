/******************************************
* 模块名称：实体 sem_feed_spu_navigation
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
	/// 实体 sem_feed_spu_navigation
	/// </summary>
	[Description("Primary:Id")]
    [Serializable]
	public class sem_feed_spu_navigation
	{
        #region 构造函数
        /// <summary>
        /// 实体 sem_feed_spu_navigation
        /// </summary>
        public sem_feed_spu_navigation(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _categorynavigation = null;
        private Int32 _cultureid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 Id(NOT NULL)
        /// </summary>
        public Int32 Id
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SpuId
        /// </summary>
        public Int32 SpuId
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 面包屑导航
        /// </summary>
        public string CategoryNavigation
        {
            set{ _categorynavigation=value;}
            get{return _categorynavigation;}
        }
        /// <summary>
        /// CultureId
        /// </summary>
        public Int32 CultureId
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
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
