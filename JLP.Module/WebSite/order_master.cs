/******************************************
* 模块名称：实体 ????
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
	/// 实体 ????
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_master
	{
        #region 构造函数
        /// <summary>
        /// 实体 ????
        /// </summary>
        public order_master(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _userguid = null;
        private string _tx = null;
        private decimal _originalproducttotalprice = decimal.MinValue;
        private decimal _originalshippingtotalprice = decimal.MinValue;
        private decimal _memberdiscountprice = decimal.MinValue;
        private decimal _realcurrentpayprice = decimal.MinValue;
        private decimal _realusdpaytotalprice = decimal.MinValue;
        private decimal _realcurrentshippingpayprice = decimal.MinValue;
        private decimal _realusdshippingpayprice = decimal.MinValue;
        private decimal _changepayprice = decimal.MinValue;
        private string _changepaycurrency = null;
        private decimal _changepayrate = decimal.MinValue;
        private decimal _tuotouprice = decimal.MinValue;
        private DateTime _intoordertime = DateTime.MinValue;
        private DateTime _paymenttime = DateTime.MinValue;
        private Int32 _paymenttype = Int32.MinValue;
        private DateTime _completedtime = DateTime.MinValue;
        private string _cancelorderleavemessage = null;
        private DateTime _cancelordertime = DateTime.MinValue;
        private DateTime _abandonordertime = DateTime.MinValue;
        private Int32 _dispatcherid = Int32.MinValue;
        private string _dispatchername = null;
        private Int32 _isdisputedorder = Int32.MinValue;
        private Int32 _isdangerorder = Int32.MinValue;
        private Int32 _isfastorder = Int32.MinValue;
        private Int32 _isfastpaypal = Int32.MinValue;
        private Int32 _isnoregister = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _currencyname = null;
        private decimal _currencyrate = decimal.MinValue;
        private Int32 _platform = Int32.MinValue;
        private Int32 _deviceplatform = Int32.MinValue;
        private string _useragent = null;
        private Int32 _useragenttype = Int32.MinValue;
        private string _userip = null;
        private Int32 _accountid = Int32.MinValue;
        private Int32 _expressid = Int32.MinValue;
        private string _expressname = null;
        private Int32 _creditcardtype = Int32.MinValue;
        private Int32 _ordermasterstate = Int32.MinValue;
        private Int32 _syncordermasterstate = Int32.MinValue;
        private DateTime _syncordermasterstatetime = DateTime.MinValue;
        private Int32 _backgroundordermasterstate = Int32.MinValue;
        private decimal _backgroundrealusdpaytotalprice = decimal.MinValue;
        private decimal _backgroundrealusdshippingpayprice = decimal.MinValue;
        private string _parameterutmsource = null;
        private string _parameterutmmedium = null;
        private string _parameterutmcampaign = null;
        private decimal _nativerealcurrentpayprice = decimal.MinValue;
        private Int32 _backgroundisdangerorder = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ?????ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
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
        /// ??????ID
        /// </summary>
        public string UserGuid
        {
            set{ _userguid=value;}
            get{return _userguid;}
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
        /// ??????(???????????????????)
        /// </summary>
        public decimal MemberDiscountPrice
        {
            set{ _memberdiscountprice=value;}
            get{return _memberdiscountprice;}
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
        /// ??????????????????????(???????????????????)
        /// </summary>
        public decimal RealUSDPayTotalPrice
        {
            set{ _realusdpaytotalprice=value;}
            get{return _realusdpaytotalprice;}
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
        /// ???????????????????????(???????????????????)
        /// </summary>
        public decimal RealUSDShippingPayPrice
        {
            set{ _realusdshippingpayprice=value;}
            get{return _realusdshippingpayprice;}
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
        public string ChangePayCurrency
        {
            set{ _changepaycurrency=value;}
            get{return _changepaycurrency;}
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
        /// ?????
        /// </summary>
        public decimal TuoTouPrice
        {
            set{ _tuotouprice=value;}
            get{return _tuotouprice;}
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
        /// ?????????????
        /// </summary>
        public DateTime CompletedTime
        {
            set{ _completedtime=value;}
            get{return _completedtime;}
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
        /// ????????
        /// </summary>
        public DateTime CancelOrderTime
        {
            set{ _cancelordertime=value;}
            get{return _cancelordertime;}
        }
        /// <summary>
        /// ??????????
        /// </summary>
        public DateTime AbandonOrderTime
        {
            set{ _abandonordertime=value;}
            get{return _abandonordertime;}
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
        /// ???????????????????????????????????????????ID?????????????????
        /// </summary>
        public string DispatcherName
        {
            set{ _dispatchername=value;}
            get{return _dispatchername;}
        }
        /// <summary>
        /// ????????????=1????=0?
        /// </summary>
        public Int32 IsDisputedOrder
        {
            set{ _isdisputedorder=value;}
            get{return _isdisputedorder;}
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
        public Int32 IsFastOrder
        {
            set{ _isfastorder=value;}
            get{return _isfastorder;}
        }
        /// <summary>
        /// ??????????????=1????=0?
        /// </summary>
        public Int32 IsFastPaypal
        {
            set{ _isfastpaypal=value;}
            get{return _isfastpaypal;}
        }
        /// <summary>
        /// ???????????????
        /// </summary>
        public Int32 IsNoRegister
        {
            set{ _isnoregister=value;}
            get{return _isnoregister;}
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
        /// ????????????????
        /// </summary>
        public string CurrencyName
        {
            set{ _currencyname=value;}
            get{return _currencyname;}
        }
        /// <summary>
        /// ????????????
        /// </summary>
        public decimal CurrencyRate
        {
            set{ _currencyrate=value;}
            get{return _currencyrate;}
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
        /// APP??????EDevicePlatform?????
        /// </summary>
        public Int32 DevicePlatform
        {
            set{ _deviceplatform=value;}
            get{return _deviceplatform;}
        }
        /// <summary>
        /// UserAgent
        /// </summary>
        public string UserAgent
        {
            set{ _useragent=value;}
            get{return _useragent;}
        }
        /// <summary>
        /// ?????
        /// </summary>
        public Int32 UserAgentType
        {
            set{ _useragenttype=value;}
            get{return _useragenttype;}
        }
        /// <summary>
        /// ??IP
        /// </summary>
        public string UserIP
        {
            set{ _userip=value;}
            get{return _userip;}
        }
        /// <summary>
        /// ??ID???ID?????????????
        /// </summary>
        public Int32 AccountID
        {
            set{ _accountid=value;}
            get{return _accountid;}
        }
        /// <summary>
        /// ??ID,??ID
        /// </summary>
        public Int32 ExpressID
        {
            set{ _expressid=value;}
            get{return _expressid;}
        }
        /// <summary>
        /// ????
        /// </summary>
        public string ExpressName
        {
            set{ _expressname=value;}
            get{return _expressname;}
        }
        /// <summary>
        /// CreditCardType(NOT NULL)
        /// </summary>
        public Int32 CreditCardType
        {
            set{ _creditcardtype=value;}
            get{return _creditcardtype;}
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
        /// ??RabbitMQ???????????
        /// </summary>
        public Int32 SyncOrderMasterState
        {
            set{ _syncordermasterstate=value;}
            get{return _syncordermasterstate;}
        }
        /// <summary>
        /// ????????
        /// </summary>
        public DateTime SyncOrderMasterStateTime
        {
            set{ _syncordermasterstatetime=value;}
            get{return _syncordermasterstatetime;}
        }
        /// <summary>
        /// ?????????RabbitMQ?????
        /// </summary>
        public Int32 BackgroundOrderMasterState
        {
            set{ _backgroundordermasterstate=value;}
            get{return _backgroundordermasterstate;}
        }
        /// <summary>
        /// 后台修改订单支付金额（单位：美金）
        /// </summary>
        public decimal BackgroundRealUSDPayTotalPrice
        {
            set{ _backgroundrealusdpaytotalprice=value;}
            get{return _backgroundrealusdpaytotalprice;}
        }
        /// <summary>
        /// 后台修改订单运费金额（单位：美金）
        /// </summary>
        public decimal BackgroundRealUSDShippingPayPrice
        {
            set{ _backgroundrealusdshippingpayprice=value;}
            get{return _backgroundrealusdshippingpayprice;}
        }
        /// <summary>
        /// ParameterUtmSource
        /// </summary>
        public string ParameterUtmSource
        {
            set{ _parameterutmsource=value;}
            get{return _parameterutmsource;}
        }
        /// <summary>
        /// ParameterUtmMedium
        /// </summary>
        public string ParameterUtmMedium
        {
            set{ _parameterutmmedium=value;}
            get{return _parameterutmmedium;}
        }
        /// <summary>
        /// ParameterUtmCampaign
        /// </summary>
        public string ParameterUtmCampaign
        {
            set{ _parameterutmcampaign=value;}
            get{return _parameterutmcampaign;}
        }
        /// <summary>
        /// 仅当后台修改订单支付金额之后，才保存这一列的值，记录用户当时生成订单时应支付的实际价格(和第一次RealCurrentPayPrice列的值相同)
        /// </summary>
        public decimal NativeRealCurrentPayPrice
        {
            set{ _nativerealcurrentpayprice=value;}
            get{return _nativerealcurrentpayprice;}
        }
        /// <summary>
        /// 订单在CMS风控状态（1：被分控，0：未风控）
        /// </summary>
        public Int32 BackgroundIsDangerOrder
        {
            set{ _backgroundisdangerorder=value;}
            get{return _backgroundisdangerorder;}
        }
        #endregion
	}
}
