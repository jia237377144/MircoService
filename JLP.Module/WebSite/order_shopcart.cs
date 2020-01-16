/******************************************
* 模块名称：实体 购物车信息
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
	/// 实体 购物车信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_shopcart
	{
        #region 构造函数
        /// <summary>
        /// 实体 购物车信息
        /// </summary>
        public order_shopcart(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _userguid = null;
        private string _userip = null;
        private Int32 _useragenttype = Int32.MinValue;
        private Int32 _shoptype = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _itemtype = Int32.MinValue;
        private string _specificationcode = null;
        private string _specificationtext = null;
        private Int32 _shopcount = Int32.MinValue;
        private string _leavemessage = null;
        private DateTime _intocarttime = DateTime.MinValue;
        private Int32 _state = Int32.MinValue;
        private Int32 _unitsize = Int32.MinValue;
        private string _sameimagecolor = null;
        private string _leimuids = null;
        private string _leimuleafids = null;
        private Int32 _priceflashid = Int32.MinValue;
        private Int32 _pricedailyspecialid = Int32.MinValue;
        private Int32 _priceincreaseid = Int32.MinValue;
        private Int32 _platform = Int32.MinValue;
        private Int32 _deviceplatform = Int32.MinValue;
        private Int32 _offshelfreasontype = Int32.MinValue;
        private string _offshelfreasonnote = null;
        private Int32 _sourcetype = Int32.MinValue;
        private string _sourcevalue = null;
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
        /// 登录用户ID，0表示未登录
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 用户全局唯一ID
        /// </summary>
        public string UserGuid
        {
            set{ _userguid=value;}
            get{return _userguid;}
        }
        /// <summary>
        /// 用户IP
        /// </summary>
        public string UserIP
        {
            set{ _userip=value;}
            get{return _userip;}
        }
        /// <summary>
        /// 浏览器信息枚举类型
        /// </summary>
        public Int32 UserAgentType
        {
            set{ _useragenttype=value;}
            get{return _useragenttype;}
        }
        /// <summary>
        /// 购买方式枚举：（1：添加购物车， 2：立即购买）
        /// </summary>
        public Int32 ShopType
        {
            set{ _shoptype=value;}
            get{return _shoptype;}
        }
        /// <summary>
        /// SPUID
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
        /// 网站产品ID，只在URL中使用
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// 购物商品多语言ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 购物车中商品的类型枚举：（正常=1，赠品=2，加价购=3，每日特价=4,闪购=5）
        /// </summary>
        public Int32 ItemType
        {
            set{ _itemtype=value;}
            get{return _itemtype;}
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
        /// 购物车中某一个SKU的数量
        /// </summary>
        public Int32 ShopCount
        {
            set{ _shopcount=value;}
            get{return _shopcount;}
        }
        /// <summary>
        /// 用户留言
        /// </summary>
        public string LeaveMessage
        {
            set{ _leavemessage=value;}
            get{return _leavemessage;}
        }
        /// <summary>
        /// 添加购物车时间
        /// </summary>
        public DateTime InToCartTime
        {
            set{ _intocarttime=value;}
            get{return _intocarttime;}
        }
        /// <summary>
        /// 购物车状态枚举：（1：有效；0：无效）
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
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
        /// PriceIncreaseID
        /// </summary>
        public Int32 PriceIncreaseID
        {
            set{ _priceincreaseid=value;}
            get{return _priceincreaseid;}
        }
        /// <summary>
        /// 生成订单时当前用户使用的平台类型枚举（PC、M、APP）
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
        }
        /// <summary>
        /// APP客户端类型（EDevicePlatform枚举类型）
        /// </summary>
        public Int32 DevicePlatform
        {
            set{ _deviceplatform=value;}
            get{return _deviceplatform;}
        }
        /// <summary>
        /// 购物车产品下架原因枚举类型
        /// </summary>
        public Int32 OffShelfReasonType
        {
            set{ _offshelfreasontype=value;}
            get{return _offshelfreasontype;}
        }
        /// <summary>
        /// 购物车产品下架原因备注信息
        /// </summary>
        public string OffShelfReasonNote
        {
            set{ _offshelfreasonnote=value;}
            get{return _offshelfreasonnote;}
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
        #endregion
	}
}
