/******************************************
* 模块名称：实体 SKU修改信息
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
	/// 实体 SKU修改信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku_modify
	{
        #region 构造函数
        /// <summary>
        /// 实体 SKU修改信息
        /// </summary>
        public product_sku_modify(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private decimal _baseprice = decimal.MinValue;
        private decimal _marketprice = decimal.MinValue;
        private decimal _sellprice = decimal.MinValue;
        private decimal _sellpricem = decimal.MinValue;
        private decimal _sellpriceapp = decimal.MinValue;
        private string _platformjson = null;
        private Int32 _formulamasterid = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _buymin = Int32.MinValue;
        private Int32 _buymax = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
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
        /// SKU基础价格（指导价格）=SKU价格*计算公式
        /// </summary>
        public decimal BasePrice
        {
            set{ _baseprice=value;}
            get{return _baseprice;}
        }
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
        /// 类目显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// SKU批量调整售卖价格主表ID，外键ID
        /// </summary>
        public Int32 FormulaMasterID
        {
            set{ _formulamasterid=value;}
            get{return _formulamasterid;}
        }
        /// <summary>
        /// SKU状态(显示=1,隐藏=0)
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 最小购买量
        /// </summary>
        public Int32 BuyMin
        {
            set{ _buymin=value;}
            get{return _buymin;}
        }
        /// <summary>
        /// 最大购买量
        /// </summary>
        public Int32 BuyMax
        {
            set{ _buymax=value;}
            get{return _buymax;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
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
