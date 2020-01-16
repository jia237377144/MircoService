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
	public class view_product_spu_modifyimage
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_modifyimage(){}
        #endregion

        #region 私有变量
        private Int32 _spuid = Int32.MinValue;
        private string _imagejson = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// SPUID（外键）
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 网站前台产品展示需要使用的所有图片ID的JSON[1,2,3,4,5]
        /// </summary>
        public string ImageJSON
        {
            set{ _imagejson=value;}
            get{return _imagejson;}
        }
        #endregion
	}
}
