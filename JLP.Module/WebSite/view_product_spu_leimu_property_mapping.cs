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
	public class view_product_spu_leimu_property_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_leimu_property_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _propertykeyid = Int32.MinValue;
        private Int32 _propertyvalueid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 类目ID(外键)
        /// </summary>
        public Int32 LeimuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 属性键ID(外键),自己这边自增的ID
        /// </summary>
        public Int32 PropertyKeyID
        {
            set{ _propertykeyid=value;}
            get{return _propertykeyid;}
        }
        /// <summary>
        /// 属性值ID(外键),自己这边自增的ID
        /// </summary>
        public Int32 PropertyValueID
        {
            set{ _propertyvalueid=value;}
            get{return _propertyvalueid;}
        }
        #endregion
	}
}
