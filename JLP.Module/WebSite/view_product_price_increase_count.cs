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
	public class view_product_price_increase_count
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_price_increase_count(){}
        #endregion

        #region 私有变量
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private string _culturejson = null;
        private Int32 _status = Int32.MinValue;
        private long _totalordercount = long.MinValue;
        private decimal _totalorderproductcount = decimal.MinValue;
        private long _totalpayordercount = long.MinValue;
        private decimal _totalpayorderproductcount = decimal.MinValue;
        private long _totalordercountpc = long.MinValue;
        private decimal _totalorderproductcountpc = decimal.MinValue;
        private long _totalpayordercountpc = long.MinValue;
        private decimal _totalpayorderproductcountpc = decimal.MinValue;
        private long _totalordercountm = long.MinValue;
        private decimal _totalorderproductcountm = decimal.MinValue;
        private long _totalpayordercountm = long.MinValue;
        private decimal _totalpayorderproductcountm = decimal.MinValue;
        private long _totalordercountapp = long.MinValue;
        private decimal _totalorderproductcountapp = decimal.MinValue;
        private long _totalpayordercountapp = long.MinValue;
        private decimal _totalpayorderproductcountapp = decimal.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 产品PID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// 产品SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 产品SKUID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 多语言JSON
        /// </summary>
        public string CultureJSON
        {
            set{ _culturejson=value;}
            get{return _culturejson;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// TotalOrderCount
        /// </summary>
        public long TotalOrderCount
        {
            set{ _totalordercount=value;}
            get{return _totalordercount;}
        }
        /// <summary>
        /// TotalOrderProductCount
        /// </summary>
        public decimal TotalOrderProductCount
        {
            set{ _totalorderproductcount=value;}
            get{return _totalorderproductcount;}
        }
        /// <summary>
        /// TotalPayOrderCount
        /// </summary>
        public long TotalPayOrderCount
        {
            set{ _totalpayordercount=value;}
            get{return _totalpayordercount;}
        }
        /// <summary>
        /// TotalPayOrderProductCount
        /// </summary>
        public decimal TotalPayOrderProductCount
        {
            set{ _totalpayorderproductcount=value;}
            get{return _totalpayorderproductcount;}
        }
        /// <summary>
        /// TotalOrderCountPC
        /// </summary>
        public long TotalOrderCountPC
        {
            set{ _totalordercountpc=value;}
            get{return _totalordercountpc;}
        }
        /// <summary>
        /// TotalOrderProductCountPC
        /// </summary>
        public decimal TotalOrderProductCountPC
        {
            set{ _totalorderproductcountpc=value;}
            get{return _totalorderproductcountpc;}
        }
        /// <summary>
        /// TotalPayOrderCountPC
        /// </summary>
        public long TotalPayOrderCountPC
        {
            set{ _totalpayordercountpc=value;}
            get{return _totalpayordercountpc;}
        }
        /// <summary>
        /// TotalPayOrderProductCountPC
        /// </summary>
        public decimal TotalPayOrderProductCountPC
        {
            set{ _totalpayorderproductcountpc=value;}
            get{return _totalpayorderproductcountpc;}
        }
        /// <summary>
        /// TotalOrderCountM
        /// </summary>
        public long TotalOrderCountM
        {
            set{ _totalordercountm=value;}
            get{return _totalordercountm;}
        }
        /// <summary>
        /// TotalOrderProductCountM
        /// </summary>
        public decimal TotalOrderProductCountM
        {
            set{ _totalorderproductcountm=value;}
            get{return _totalorderproductcountm;}
        }
        /// <summary>
        /// TotalPayOrderCountM
        /// </summary>
        public long TotalPayOrderCountM
        {
            set{ _totalpayordercountm=value;}
            get{return _totalpayordercountm;}
        }
        /// <summary>
        /// TotalPayOrderProductCountM
        /// </summary>
        public decimal TotalPayOrderProductCountM
        {
            set{ _totalpayorderproductcountm=value;}
            get{return _totalpayorderproductcountm;}
        }
        /// <summary>
        /// TotalOrderCountAPP
        /// </summary>
        public long TotalOrderCountAPP
        {
            set{ _totalordercountapp=value;}
            get{return _totalordercountapp;}
        }
        /// <summary>
        /// TotalOrderProductCountAPP
        /// </summary>
        public decimal TotalOrderProductCountAPP
        {
            set{ _totalorderproductcountapp=value;}
            get{return _totalorderproductcountapp;}
        }
        /// <summary>
        /// TotalPayOrderCountAPP
        /// </summary>
        public long TotalPayOrderCountAPP
        {
            set{ _totalpayordercountapp=value;}
            get{return _totalpayordercountapp;}
        }
        /// <summary>
        /// TotalPayOrderProductCountAPP
        /// </summary>
        public decimal TotalPayOrderProductCountAPP
        {
            set{ _totalpayorderproductcountapp=value;}
            get{return _totalpayorderproductcountapp;}
        }
        #endregion
	}
}
