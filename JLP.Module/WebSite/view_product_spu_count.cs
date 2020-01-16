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
	public class view_product_spu_count
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_count(){}
        #endregion

        #region 私有变量
        private long _spucount = long.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// SpuCount(NOT NULL)
        /// </summary>
        public long SpuCount
        {
            set{ _spucount=value;}
            get{return _spucount;}
        }
        #endregion
	}
}
