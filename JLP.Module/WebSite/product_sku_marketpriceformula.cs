/******************************************
* 模块名称：实体 SKU批量调整市场价格
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
	/// 实体 SKU批量调整市场价格
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku_marketpriceformula
	{
        #region 构造函数
        /// <summary>
        /// 实体 SKU批量调整市场价格
        /// </summary>
        public product_sku_marketpriceformula(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private string _categoryname = null;
        private decimal _minrate = decimal.MinValue;
        private decimal _maxrate = decimal.MinValue;
        private Int32 _calcrule = Int32.MinValue;
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
        /// 最小倍率
        /// </summary>
        public decimal MinRate
        {
            set{ _minrate=value;}
            get{return _minrate;}
        }
        /// <summary>
        /// 最大倍率
        /// </summary>
        public decimal MaxRate
        {
            set{ _maxrate=value;}
            get{return _maxrate;}
        }
        /// <summary>
        /// 计算规则枚举：(在倍率间随机、按最大倍率和按最小倍率)
        /// </summary>
        public Int32 CalcRule
        {
            set{ _calcrule=value;}
            get{return _calcrule;}
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
