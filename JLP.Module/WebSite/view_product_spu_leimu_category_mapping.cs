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
	public class view_product_spu_leimu_category_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_leimu_category_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _spuid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private string _leimuid = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 品类ID (外键),PMS那里的品类ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// LeiMuID
        /// </summary>
        public string LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        #endregion
	}
}
