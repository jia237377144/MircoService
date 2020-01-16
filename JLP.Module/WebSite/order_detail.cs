/******************************************
* 模块名称：实体 订单明细表
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
	/// 实体 订单明细表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_detail
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单明细表
        /// </summary>
        public order_detail(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _buycount = Int32.MinValue;
        private decimal _unitprice = decimal.MinValue;
        private string _leavemessage = null;
        private string _specificationcode = null;
        private string _specificationtext = null;
        private string _expressname = null;
        private string _expressno = null;
        private Int32 _itemtype = Int32.MinValue;
        private Int32 _isdisputedorder = Int32.MinValue;
        private DateTime _completedtime = DateTime.MinValue;
        private Int32 _accountid = Int32.MinValue;
        private Int32 _orderdetailstate = Int32.MinValue;
        private Int32 _syncorderdetailstate = Int32.MinValue;
        private Int32 _backgroundorderdetailstate = Int32.MinValue;
        private Int32 _unitsize = Int32.MinValue;
        private string _sameimagecolor = null;
        private string _sameimageurl = null;
        private string _leimuids = null;
        private string _leimuleafids = null;
        private Int32 _priceflashid = Int32.MinValue;
        private Int32 _pricedailyspecialid = Int32.MinValue;
        private Int32 _skutype = Int32.MinValue;
        private Int32 _ispackagebox = Int32.MinValue;
        private Int32 _priceincreaseid = Int32.MinValue;
        private Int32 _isshow = Int32.MinValue;
        private decimal _requestrefundproductprice = decimal.MinValue;
        private decimal _requestrefundshippingprice = decimal.MinValue;
        private decimal _requestrefundprice = decimal.MinValue;
        private decimal _responserefundprice = decimal.MinValue;
        private Int32 _isexchangeorder = Int32.MinValue;
        private Int32 _exchangeorderdetailstate = Int32.MinValue;
        private Int32 _packageweight = Int32.MinValue;
        private Int32 _sourcetype = Int32.MinValue;
        private string _sourcevalue = null;
        private Int32 _backgroundenablerefund = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 主单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 产品URL中的ID，外键ID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// SPUID，外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID，外键ID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 多语言编号，外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 购买书量
        /// </summary>
        public Int32 BuyCount
        {
            set{ _buycount=value;}
            get{return _buycount;}
        }
        /// <summary>
        /// SKU单价（活动价或售卖价）
        /// </summary>
        public decimal UnitPrice
        {
            set{ _unitprice=value;}
            get{return _unitprice;}
        }
        /// <summary>
        /// 用户对子单的留言信息
        /// </summary>
        public string LeaveMessage
        {
            set{ _leavemessage=value;}
            get{return _leavemessage;}
        }
        /// <summary>
        /// 规格编码,如：2014=456&2015=3654&856=451（选中的必选区键值对）
        /// </summary>
        public string SpecificationCode
        {
            set{ _specificationcode=value;}
            get{return _specificationcode;}
        }
        /// <summary>
        /// 规格描述,如：颜色=红色&尺寸=XL（选中的必选区键值对名称信息）
        /// </summary>
        public string SpecificationText
        {
            set{ _specificationtext=value;}
            get{return _specificationtext;}
        }
        /// <summary>
        /// 快递方式名称
        /// </summary>
        public string ExpressName
        {
            set{ _expressname=value;}
            get{return _expressname;}
        }
        /// <summary>
        /// 快递运单编号
        /// </summary>
        public string ExpressNo
        {
            set{ _expressno=value;}
            get{return _expressno;}
        }
        /// <summary>
        /// 子单类型枚举（正常、赠品、补单）
        /// </summary>
        public Int32 ItemType
        {
            set{ _itemtype=value;}
            get{return _itemtype;}
        }
        /// <summary>
        /// 是否为争议订单枚举（争议=1，非争议=0）
        /// </summary>
        public Int32 IsDisputedOrder
        {
            set{ _isdisputedorder=value;}
            get{return _isdisputedorder;}
        }
        /// <summary>
        /// 用户点击确认完成订单的时间
        /// </summary>
        public DateTime CompletedTime
        {
            set{ _completedtime=value;}
            get{return _completedtime;}
        }
        /// <summary>
        /// 职员ID，外键ID，需要后台修改订单时才有值
        /// </summary>
        public Int32 AccountID
        {
            set{ _accountid=value;}
            get{return _accountid;}
        }
        /// <summary>
        /// 子订单状态枚举
        /// </summary>
        public Int32 OrderDetailState
        {
            set{ _orderdetailstate=value;}
            get{return _orderdetailstate;}
        }
        /// <summary>
        /// 前台RabbitMQ同步之后子订单状态枚举
        /// </summary>
        public Int32 SyncOrderDetailState
        {
            set{ _syncorderdetailstate=value;}
            get{return _syncorderdetailstate;}
        }
        /// <summary>
        /// 后台修改子订单状态RabbitMQ同步到前台
        /// </summary>
        public Int32 BackgroundOrderDetailState
        {
            set{ _backgroundorderdetailstate=value;}
            get{return _backgroundorderdetailstate;}
        }
        /// <summary>
        /// SKU必选区尺寸的单位枚举类型(厘米：0，英尺：1)
        /// </summary>
        public Int32 UnitSize
        {
            set{ _unitsize=value;}
            get{return _unitsize;}
        }
        /// <summary>
        /// 同图片色
        /// </summary>
        public string SameImageColor
        {
            set{ _sameimagecolor=value;}
            get{return _sameimagecolor;}
        }
        /// <summary>
        /// 同图片色的产品图片URL
        /// </summary>
        public string SameImageUrl
        {
            set{ _sameimageurl=value;}
            get{return _sameimageurl;}
        }
        /// <summary>
        /// SPU所属多个类目ID的数组
        /// </summary>
        public string LeiMuIds
        {
            set{ _leimuids=value;}
            get{return _leimuids;}
        }
        /// <summary>
        /// SPU所属多个类目ID的数组(只存页级类目ID的数组)
        /// </summary>
        public string LeiMuLeafIds
        {
            set{ _leimuleafids=value;}
            get{return _leimuleafids;}
        }
        /// <summary>
        /// 闪购价格ID，0表示没有闪购价格
        /// </summary>
        public Int32 PriceFlashID
        {
            set{ _priceflashid=value;}
            get{return _priceflashid;}
        }
        /// <summary>
        /// 每日特价ID，0表示没有每日特价
        /// </summary>
        public Int32 PriceDailySpecialID
        {
            set{ _pricedailyspecialid=value;}
            get{return _pricedailyspecialid;}
        }
        /// <summary>
        /// SKU枚举类型(对应EProduct_SKU_SkuType类型)
        /// </summary>
        public Int32 SkuType
        {
            set{ _skutype=value;}
            get{return _skutype;}
        }
        /// <summary>
        /// IsPackageBox
        /// </summary>
        public Int32 IsPackageBox
        {
            set{ _ispackagebox=value;}
            get{return _ispackagebox;}
        }
        /// <summary>
        /// PriceIncreaseID
        /// </summary>
        public Int32 PriceIncreaseID
        {
            set{ _priceincreaseid=value;}
            get{return _priceincreaseid;}
        }
        /// <summary>
        /// 是否显示子单
        /// </summary>
        public Int32 IsShow
        {
            set{ _isshow=value;}
            get{return _isshow;}
        }
        /// <summary>
        /// 请求退换货产品金额（付款时使用什么币种这里就是对应币种的金额）
        /// </summary>
        public decimal RequestRefundProductPrice
        {
            set{ _requestrefundproductprice=value;}
            get{return _requestrefundproductprice;}
        }
        /// <summary>
        /// 请求退换货运费金额（付款时使用什么币种这里就是对应币种的金额）
        /// </summary>
        public decimal RequestRefundShippingPrice
        {
            set{ _requestrefundshippingprice=value;}
            get{return _requestrefundshippingprice;}
        }
        /// <summary>
        /// 请求退换货金额（付款时使用什么币种这里就是对应币种的金额）
        /// </summary>
        public decimal RequestRefundPrice
        {
            set{ _requestrefundprice=value;}
            get{return _requestrefundprice;}
        }
        /// <summary>
        /// 后端最终协商之后的真实退款金额（付款时使用什么币种这里就是对应币种的金额）
        /// </summary>
        public decimal ResponseRefundPrice
        {
            set{ _responserefundprice=value;}
            get{return _responserefundprice;}
        }
        /// <summary>
        /// 是否是换货新产生子单（1是，0不是）
        /// </summary>
        public Int32 IsExchangeOrder
        {
            set{ _isexchangeorder=value;}
            get{return _isexchangeorder;}
        }
        /// <summary>
        /// 退换货子单状态
        /// </summary>
        public Int32 ExchangeOrderDetailState
        {
            set{ _exchangeorderdetailstate=value;}
            get{return _exchangeorderdetailstate;}
        }
        /// <summary>
        /// 包装重量(参考值) [单位:克]
        /// </summary>
        public Int32 PackageWeight
        {
            set{ _packageweight=value;}
            get{return _packageweight;}
        }
        /// <summary>
        /// 产品来源类型
        /// </summary>
        public Int32 SourceType
        {
            set{ _sourcetype=value;}
            get{return _sourcetype;}
        }
        /// <summary>
        /// 产品来源值，多个值用逗号分割
        /// </summary>
        public string SourceValue
        {
            set{ _sourcevalue=value;}
            get{return _sourcevalue;}
        }
        /// <summary>
        /// 是否允许退款，CMS传过来的（1：允许，0：不允许）
        /// </summary>
        public Int32 BackgroundEnableRefund
        {
            set{ _backgroundenablerefund=value;}
            get{return _backgroundenablerefund;}
        }
        #endregion
	}
}
