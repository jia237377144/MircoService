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
	public class view_product_spu_price
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_price(){}
        #endregion

        #region 私有变量
        private decimal _marketprice = decimal.MinValue;
        private decimal _sellprice = decimal.MinValue;
        private decimal _sellpricem = decimal.MinValue;
        private decimal _sellpriceapp = decimal.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 市场价，根据BasePrice通过公式计算出来
        /// </summary>
        public decimal MarketPrice
        {
            set{ _marketprice=value;}
            get{return _marketprice;}
        }
        /// <summary>
        /// 网站SKU卖价（市场部批量调价，最终网站展示到网站的售价，如果SKU做活动之后取活动之后的活动价，没有活动价就取本列的售价）
        /// </summary>
        public decimal SellPrice
        {
            set{ _sellprice=value;}
            get{return _sellprice;}
        }
        /// <summary>
        /// M站的SKU卖价
        /// </summary>
        public decimal SellPriceM
        {
            set{ _sellpricem=value;}
            get{return _sellpricem;}
        }
        /// <summary>
        /// App的SKU卖价
        /// </summary>
        public decimal SellPriceApp
        {
            set{ _sellpriceapp=value;}
            get{return _sellpriceapp;}
        }
        /// <summary>
        /// SPUID，外键
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID，外键
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 类目ID(外键)
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 品类ID (外键),PMS那里的品类ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        #endregion
	}
}
