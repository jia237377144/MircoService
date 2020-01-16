/******************************************
* 模块名称：实体 产品库存量表
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
	/// 实体 产品库存量表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_stock
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品库存量表
        /// </summary>
        public product_stock(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _stockcount = Int32.MinValue;
        private Int32 _lockcount = Int32.MinValue;
        private Int32 _issaleonlystock = Int32.MinValue;
        private DateTime _updatestocktime = DateTime.MinValue;
        private DateTime _updatelocktime = DateTime.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SUPID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 库存量(ERP同步库存量时覆盖,支付成功数量减一)
        /// </summary>
        public Int32 StockCount
        {
            set{ _stockcount=value;}
            get{return _stockcount;}
        }
        /// <summary>
        /// 库存锁定量(生成订单数量加一,支付成功数量减一)
        /// </summary>
        public Int32 LockCount
        {
            set{ _lockcount=value;}
            get{return _lockcount;}
        }
        /// <summary>
        /// (0是不售卖，1是售卖)
        /// </summary>
        public Int32 IsSaleOnlyStock
        {
            set{ _issaleonlystock=value;}
            get{return _issaleonlystock;}
        }
        /// <summary>
        /// 库存量这一列更新时间
        /// </summary>
        public DateTime UpdateStockTime
        {
            set{ _updatestocktime=value;}
            get{return _updatestocktime;}
        }
        /// <summary>
        /// 库存锁定量这一列更新时间
        /// </summary>
        public DateTime UpdateLockTime
        {
            set{ _updatelocktime=value;}
            get{return _updatelocktime;}
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
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
