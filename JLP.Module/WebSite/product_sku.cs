/******************************************
* 模块名称：实体 产品SKU
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
	/// 实体 产品SKU
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品SKU
        /// </summary>
        public product_sku(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _specificationcode = null;
        private string _specificationtext = null;
        private string _hash = null;
        private Int32 _leadtimemax = Int32.MinValue;
        private Int32 _leadtimemin = Int32.MinValue;
        private Int32 _isvalid = Int32.MinValue;
        private decimal _costprice = decimal.MinValue;
        private Int32 _stockcount = Int32.MinValue;
        private Int32 _skutype = Int32.MinValue;
        private Int32 _syncstatus = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private string _createusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SPU ID  (外键)
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 规格编码（选中的必选区键值对）。如：2014=456&2015=3654&856=451
        /// </summary>
        public string SpecificationCode
        {
            set{ _specificationcode=value;}
            get{return _specificationcode;}
        }
        /// <summary>
        /// 规格文本
        /// </summary>
        public string SpecificationText
        {
            set{ _specificationtext=value;}
            get{return _specificationtext;}
        }
        /// <summary>
        /// 此值是通过 必选区keyID 升序排列后形成的 SpecificationCode 的Md5值
        /// </summary>
        public string Hash
        {
            set{ _hash=value;}
            get{return _hash;}
        }
        /// <summary>
        /// 最大备货期
        /// </summary>
        public Int32 LeadTimeMax
        {
            set{ _leadtimemax=value;}
            get{return _leadtimemax;}
        }
        /// <summary>
        /// 最小备货期
        /// </summary>
        public Int32 LeadTimeMin
        {
            set{ _leadtimemin=value;}
            get{return _leadtimemin;}
        }
        /// <summary>
        /// 是否是一个有效的SKU
        /// </summary>
        public Int32 IsValid
        {
            set{ _isvalid=value;}
            get{return _isvalid;}
        }
        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice
        {
            set{ _costprice=value;}
            get{return _costprice;}
        }
        /// <summary>
        /// 库存量(保留字段)
        /// </summary>
        public Int32 StockCount
        {
            set{ _stockcount=value;}
            get{return _stockcount;}
        }
        /// <summary>
        /// SKU类型，枚举类型（普通，无销售属性，定制）
        /// </summary>
        public Int32 SkuType
        {
            set{ _skutype=value;}
            get{return _skutype;}
        }
        /// <summary>
        /// PMS同步状态，本列不是PMS那边该表的列（有效=1，无效=0）
        /// </summary>
        public Int32 SyncStatus
        {
            set{ _syncstatus=value;}
            get{return _syncstatus;}
        }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// CreateUserName
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
