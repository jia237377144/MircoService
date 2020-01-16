/******************************************
* 模块名称：实体 product_solr_data_source
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
	/// 实体 product_solr_data_source
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class product_solr_data_source
	{
        #region 构造函数
        /// <summary>
        /// 实体 product_solr_data_source
        /// </summary>
        public product_solr_data_source(){}
        #endregion

        #region 私有变量
        private Int32 _spuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _platform = Int32.MinValue;
        private Int32 _salevolume = Int32.MinValue;
        private string _leimusort = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 多语言ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 平台ID
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
        }
        /// <summary>
        /// 销售数量
        /// </summary>
        public Int32 SaleVolume
        {
            set{ _salevolume=value;}
            get{return _salevolume;}
        }
        /// <summary>
        /// 类目排序，格式：LeiMuID=Sort&LeiMuID=Sort
        /// </summary>
        public string LeimuSort
        {
            set{ _leimusort=value;}
            get{return _leimusort;}
        }
        #endregion
	}
}
