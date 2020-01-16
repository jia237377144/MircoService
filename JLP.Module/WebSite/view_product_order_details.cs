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
	public class view_product_order_details
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_order_details(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _platform = Int32.MinValue;
        private DateTime _intoordertime = DateTime.MinValue;
        private string _cancelorderleavemessage = null;
        private Int32 _isdangerorder = Int32.MinValue;
        private Int32 _ordermasterdisputed = Int32.MinValue;
        private string _dispatchername = null;
        private Int32 _dispatcherid = Int32.MinValue;
        private Int32 _ordermasterstate = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _email = null;
        private string _regip = null;
        private DateTime _regdate = DateTime.MinValue;
        private Int32 _userlevel = Int32.MinValue;
        private string _shippingfullname = null;
        private Int32 _shippingcountryid = Int32.MinValue;
        private string _shippingprovince = null;
        private string _shippingcity = null;
        private string _shippingaddress1 = null;
        private string _shippingaddress2 = null;
        private string _shippingpostcode = null;
        private string _shippingphone = null;
        private string _billingfullname = null;
        private Int32 _billingcountryid = Int32.MinValue;
        private string _billingprovince = null;
        private string _billingcity = null;
        private string _billingaddress1 = null;
        private string _billingaddress2 = null;
        private string _billingpostcode = null;
        private string _billingphone = null;
        private decimal _realcurrentpayprice = decimal.MinValue;
        private decimal _realcurrentshippingpayprice = decimal.MinValue;
        private decimal _originalproducttotalprice = decimal.MinValue;
        private decimal _originalshippingtotalprice = decimal.MinValue;
        private string _changepaycurrency = null;
        private decimal _changepayprice = decimal.MinValue;
        private decimal _changepayrate = decimal.MinValue;
        private DateTime _paymenttime = DateTime.MinValue;
        private Int32 _paymenttype = Int32.MinValue;
        private string _tx = null;
        private string _currencyname = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// ?????ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// ???ID???ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// ???????????????????PC?M?APP?
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
        }
        /// <summary>
        /// ?????????
        /// </summary>
        public DateTime InToOrderTime
        {
            set{ _intoordertime=value;}
            get{return _intoordertime;}
        }
        /// <summary>
        /// ?????????
        /// </summary>
        public string CancelOrderLeaveMessage
        {
            set{ _cancelorderleavemessage=value;}
            get{return _cancelorderleavemessage;}
        }
        /// <summary>
        /// ????????????=1????=0?
        /// </summary>
        public Int32 IsDangerOrder
        {
            set{ _isdangerorder=value;}
            get{return _isdangerorder;}
        }
        /// <summary>
        /// ????????????=1????=0?
        /// </summary>
        public Int32 OrderMasterDisputed
        {
            set{ _ordermasterdisputed=value;}
            get{return _ordermasterdisputed;}
        }
        /// <summary>
        /// ???????????????????????????????????????????ID?????????????????
        /// </summary>
        public string DispatcherName
        {
            set{ _dispatchername=value;}
            get{return _dispatchername;}
        }
        /// <summary>
        /// ???????????????ID
        /// </summary>
        public Int32 DispatcherID
        {
            set{ _dispatcherid=value;}
            get{return _dispatcherid;}
        }
        /// <summary>
        /// ???????
        /// </summary>
        public Int32 OrderMasterState
        {
            set{ _ordermasterstate=value;}
            get{return _ordermasterstate;}
        }
        /// <summary>
        /// ???????ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 登录邮箱（等同于登录名称）
        /// </summary>
        public string Email
        {
            set{ _email=value;}
            get{return _email;}
        }
        /// <summary>
        /// 注册IP
        /// </summary>
        public string RegIP
        {
            set{ _regip=value;}
            get{return _regip;}
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegDate
        {
            set{ _regdate=value;}
            get{return _regdate;}
        }
        /// <summary>
        /// 用户等级（采用之前的枚举，如：vip1，vip2）
        /// </summary>
        public Int32 UserLevel
        {
            set{ _userlevel=value;}
            get{return _userlevel;}
        }
        /// <summary>
        /// ShippingFullName
        /// </summary>
        public string ShippingFullName
        {
            set{ _shippingfullname=value;}
            get{return _shippingfullname;}
        }
        /// <summary>
        /// 收货人国家ID，外键ID
        /// </summary>
        public Int32 ShippingCountryID
        {
            set{ _shippingcountryid=value;}
            get{return _shippingcountryid;}
        }
        /// <summary>
        /// 收货人省份名称
        /// </summary>
        public string ShippingProvince
        {
            set{ _shippingprovince=value;}
            get{return _shippingprovince;}
        }
        /// <summary>
        /// 收货人城市名称
        /// </summary>
        public string ShippingCity
        {
            set{ _shippingcity=value;}
            get{return _shippingcity;}
        }
        /// <summary>
        /// 收货人地址或账单地址1
        /// </summary>
        public string ShippingAddress1
        {
            set{ _shippingaddress1=value;}
            get{return _shippingaddress1;}
        }
        /// <summary>
        /// 收货人地址或账单地址2
        /// </summary>
        public string ShippingAddress2
        {
            set{ _shippingaddress2=value;}
            get{return _shippingaddress2;}
        }
        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string ShippingPostCode
        {
            set{ _shippingpostcode=value;}
            get{return _shippingpostcode;}
        }
        /// <summary>
        /// 收货人电话号码
        /// </summary>
        public string ShippingPhone
        {
            set{ _shippingphone=value;}
            get{return _shippingphone;}
        }
        /// <summary>
        /// BillingFullName
        /// </summary>
        public string BillingFullName
        {
            set{ _billingfullname=value;}
            get{return _billingfullname;}
        }
        /// <summary>
        /// 收货人国家ID，外键ID
        /// </summary>
        public Int32 BillingCountryID
        {
            set{ _billingcountryid=value;}
            get{return _billingcountryid;}
        }
        /// <summary>
        /// 收货人省份名称
        /// </summary>
        public string BillingProvince
        {
            set{ _billingprovince=value;}
            get{return _billingprovince;}
        }
        /// <summary>
        /// 收货人城市名称
        /// </summary>
        public string BillingCity
        {
            set{ _billingcity=value;}
            get{return _billingcity;}
        }
        /// <summary>
        /// 收货人地址或账单地址1
        /// </summary>
        public string BillingAddress1
        {
            set{ _billingaddress1=value;}
            get{return _billingaddress1;}
        }
        /// <summary>
        /// 收货人地址或账单地址2
        /// </summary>
        public string BillingAddress2
        {
            set{ _billingaddress2=value;}
            get{return _billingaddress2;}
        }
        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string BillingPostCode
        {
            set{ _billingpostcode=value;}
            get{return _billingpostcode;}
        }
        /// <summary>
        /// 收货人电话号码
        /// </summary>
        public string BillingPhone
        {
            set{ _billingphone=value;}
            get{return _billingphone;}
        }
        /// <summary>
        /// ??????????????????????(???????????,??????)
        /// </summary>
        public decimal RealCurrentPayPrice
        {
            set{ _realcurrentpayprice=value;}
            get{return _realcurrentpayprice;}
        }
        /// <summary>
        /// ???????????????????????(???????????,??????)
        /// </summary>
        public decimal RealCurrentShippingPayPrice
        {
            set{ _realcurrentshippingpayprice=value;}
            get{return _realcurrentshippingpayprice;}
        }
        /// <summary>
        /// ???????????(????)
        /// </summary>
        public decimal OriginalProductTotalPrice
        {
            set{ _originalproducttotalprice=value;}
            get{return _originalproducttotalprice;}
        }
        /// <summary>
        /// ?????????????(????)
        /// </summary>
        public decimal OriginalShippingTotalPrice
        {
            set{ _originalshippingtotalprice=value;}
            get{return _originalshippingtotalprice;}
        }
        /// <summary>
        /// ???????????????
        /// </summary>
        public string ChangePayCurrency
        {
            set{ _changepaycurrency=value;}
            get{return _changepaycurrency;}
        }
        /// <summary>
        /// ???????????????
        /// </summary>
        public decimal ChangePayPrice
        {
            set{ _changepayprice=value;}
            get{return _changepayprice;}
        }
        /// <summary>
        /// ???????????????
        /// </summary>
        public decimal ChangePayRate
        {
            set{ _changepayrate=value;}
            get{return _changepayrate;}
        }
        /// <summary>
        /// ???????????
        /// </summary>
        public DateTime PaymentTime
        {
            set{ _paymenttime=value;}
            get{return _paymenttime;}
        }
        /// <summary>
        /// ??????????(PayPal,GC)
        /// </summary>
        public Int32 PaymentType
        {
            set{ _paymenttype=value;}
            get{return _paymenttype;}
        }
        /// <summary>
        /// ?????
        /// </summary>
        public string TX
        {
            set{ _tx=value;}
            get{return _tx;}
        }
        /// <summary>
        /// ????????????????
        /// </summary>
        public string CurrencyName
        {
            set{ _currencyname=value;}
            get{return _currencyname;}
        }
        #endregion
	}
}
