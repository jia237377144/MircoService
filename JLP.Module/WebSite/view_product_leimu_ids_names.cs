﻿/******************************************
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
	public class view_product_leimu_ids_names
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_leimu_ids_names(){}
        #endregion

        #region 私有变量
        private Int32 _spuid = Int32.MinValue;
        private string _leimuid = null;
        private string _leimuname = null;
        private string _urlname = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// SPU ID(外键)
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// LeiMuID
        /// </summary>
        public string LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// LeiMuName
        /// </summary>
        public string LeiMuName
        {
            set{ _leimuname=value;}
            get{return _leimuname;}
        }
        /// <summary>
        /// UrlName
        /// </summary>
        public string UrlName
        {
            set{ _urlname=value;}
            get{return _urlname;}
        }
        #endregion
	}
}
