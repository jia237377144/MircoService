/******************************************
* 模块名称：实体 网站SPU自增ID(每个站的SPUID在前台网站显示时,需要各自独立的ID)
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
	/// 实体 网站SPU自增ID(每个站的SPUID在前台网站显示时,需要各自独立的ID)
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_site_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 网站SPU自增ID(每个站的SPUID在前台网站显示时,需要各自独立的ID)
        /// </summary>
        public product_spu_site_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 站点SPUID，网站前台URL中显示的产品ID，PMS传过来的(NOT NULL)
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
        #endregion
	}
}
