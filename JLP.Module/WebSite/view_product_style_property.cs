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
	public class view_product_style_property
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_style_property(){}
        #endregion

        #region 私有变量
        private Int32 _propertyvalueid = Int32.MinValue;
        private string _text = null;
        private Int32 _categoryid = Int32.MinValue;
        private long _spucount = long.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 属性值ID(外键),自己这边自增的ID
        /// </summary>
        public Int32 PropertyValueID
        {
            set{ _propertyvalueid=value;}
            get{return _propertyvalueid;}
        }
        /// <summary>
        /// 属性值的显示文本
        /// </summary>
        public string Text
        {
            set{ _text=value;}
            get{return _text;}
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
        /// SPUCount(NOT NULL)
        /// </summary>
        public long SPUCount
        {
            set{ _spucount=value;}
            get{return _spucount;}
        }
        #endregion
	}
}
