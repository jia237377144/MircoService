/******************************************
* 模块名称：实体 SEM中FEED的线上产品
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
	/// 实体 SEM中FEED的线上产品
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class sem_feed_product_online
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEM中FEED的线上产品
        /// </summary>
        public sem_feed_product_online(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _feedinfoleimuid = Int32.MinValue;
        private Int32 _spuleimumappingleimuid = Int32.MinValue;
        private Int32 _googlecategoryid = Int32.MinValue;
        private string _googlecategorynames = null;
        private Int32 _colorrequiredkeyid = Int32.MinValue;
        private Int32 _colorrequiredvalueid = Int32.MinValue;
        private Int32 _sizerequiredkeyid = Int32.MinValue;
        private Int32 _sizerequiredvalueid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        /// <summary>
        /// 站点ID，外键ID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
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
        /// SKUID，外键ID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// Feed_Info表里面的LeiMuID
        /// </summary>
        public Int32 FeedInfoLeimuID
        {
            set{ _feedinfoleimuid=value;}
            get{return _feedinfoleimuid;}
        }
        /// <summary>
        /// SPU_LeiMu_Mapping表里面的LeimuID
        /// </summary>
        public Int32 SPULeiMuMappingLeimuID
        {
            set{ _spuleimumappingleimuid=value;}
            get{return _spuleimumappingleimuid;}
        }
        /// <summary>
        /// 谷哥上的类目ID
        /// </summary>
        public Int32 GoogleCategoryID
        {
            set{ _googlecategoryid=value;}
            get{return _googlecategoryid;}
        }
        /// <summary>
        /// 谷哥上的类目名称
        /// </summary>
        public string GoogleCategoryNames
        {
            set{ _googlecategorynames=value;}
            get{return _googlecategorynames;}
        }
        /// <summary>
        /// 颜色必选区键ID
        /// </summary>
        public Int32 ColorRequiredKeyID
        {
            set{ _colorrequiredkeyid=value;}
            get{return _colorrequiredkeyid;}
        }
        /// <summary>
        /// 颜色必选区值ID
        /// </summary>
        public Int32 ColorRequiredValueID
        {
            set{ _colorrequiredvalueid=value;}
            get{return _colorrequiredvalueid;}
        }
        /// <summary>
        /// 尺寸必选区键ID
        /// </summary>
        public Int32 SizeRequiredKeyID
        {
            set{ _sizerequiredkeyid=value;}
            get{return _sizerequiredkeyid;}
        }
        /// <summary>
        /// 尺寸必选区值ID
        /// </summary>
        public Int32 SizeRequiredValueID
        {
            set{ _sizerequiredvalueid=value;}
            get{return _sizerequiredvalueid;}
        }
        #endregion
	}
}
