/******************************************
* 模块名称：实体 按照SKU的价格，进行网站指导价格的计算，本表存储公式，仅在导入SKU是设置价格用到该公式
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
	/// 实体 按照SKU的价格，进行网站指导价格的计算，本表存储公式，仅在导入SKU是设置价格用到该公式
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku_basepriceformula
	{
        #region 构造函数
        /// <summary>
        /// 实体 按照SKU的价格，进行网站指导价格的计算，本表存储公式，仅在导入SKU是设置价格用到该公式
        /// </summary>
        public product_sku_basepriceformula(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private string _categoryname = null;
        private string _formula = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _createusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 品类ID，PMS的
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 品类名称
        /// </summary>
        public string CategoryName
        {
            set{ _categoryname=value;}
            get{return _categoryname;}
        }
        /// <summary>
        /// 基础价格（指导价格）计算公式
        /// </summary>
        public string Formula
        {
            set{ _formula=value;}
            get{return _formula;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// 创建用户名
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// 修改用户名
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
