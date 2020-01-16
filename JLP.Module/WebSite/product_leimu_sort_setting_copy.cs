/******************************************
* 模块名称：实体 类目排序表
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
	/// 实体 类目排序表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_leimu_sort_setting_copy
	{
        #region 构造函数
        /// <summary>
        /// 实体 类目排序表
        /// </summary>
        public product_leimu_sort_setting_copy(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _platform = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
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
        /// 类目ID，外键ID
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 多语言ID，外键ID
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
        /// 类目排序值
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        #endregion
	}
}
