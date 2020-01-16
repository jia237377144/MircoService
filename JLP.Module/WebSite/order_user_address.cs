/******************************************
* 模块名称：实体 用户生成订单后需要存放用户送货地址
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
	/// 实体 用户生成订单后需要存放用户送货地址
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_user_address
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户生成订单后需要存放用户送货地址
        /// </summary>
        public order_user_address(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _fullname = null;
        private string _firstname = null;
        private string _lastname = null;
        private Int32 _countryid = Int32.MinValue;
        private string _countryareacode = null;
        private string _phone = null;
        private string _taxid = null;
        private string _province = null;
        private string _city = null;
        private string _address1 = null;
        private string _address2 = null;
        private string _postcode = null;
        private Int32 _addresstype = Int32.MinValue;
        private Int32 _isdefault = Int32.MinValue;
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
        /// 用户ID，外键
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 收货人全名
        /// </summary>
        public string FullName
        {
            set{ _fullname=value;}
            get{return _fullname;}
        }
        /// <summary>
        /// 收货人的FirstName
        /// </summary>
        public string FirstName
        {
            set{ _firstname=value;}
            get{return _firstname;}
        }
        /// <summary>
        /// 收货人的LastName
        /// </summary>
        public string LastName
        {
            set{ _lastname=value;}
            get{return _lastname;}
        }
        /// <summary>
        /// 收货人国家ID，外键ID
        /// </summary>
        public Int32 CountryID
        {
            set{ _countryid=value;}
            get{return _countryid;}
        }
        /// <summary>
        /// 收货人国家区号
        /// </summary>
        public string CountryAreaCode
        {
            set{ _countryareacode=value;}
            get{return _countryareacode;}
        }
        /// <summary>
        /// 收货人电话号码
        /// </summary>
        public string Phone
        {
            set{ _phone=value;}
            get{return _phone;}
        }
        /// <summary>
        /// TaxID
        /// </summary>
        public string TaxID
        {
            set{ _taxid=value;}
            get{return _taxid;}
        }
        /// <summary>
        /// 收货人省份名称
        /// </summary>
        public string Province
        {
            set{ _province=value;}
            get{return _province;}
        }
        /// <summary>
        /// 收货人城市名称
        /// </summary>
        public string City
        {
            set{ _city=value;}
            get{return _city;}
        }
        /// <summary>
        /// 收货人地址或账单地址1
        /// </summary>
        public string Address1
        {
            set{ _address1=value;}
            get{return _address1;}
        }
        /// <summary>
        /// 收货人地址或账单地址2
        /// </summary>
        public string Address2
        {
            set{ _address2=value;}
            get{return _address2;}
        }
        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string PostCode
        {
            set{ _postcode=value;}
            get{return _postcode;}
        }
        /// <summary>
        /// 地址类型枚举：（账单地址=2，收货人地址=1)
        /// </summary>
        public Int32 AddressType
        {
            set{ _addresstype=value;}
            get{return _addresstype;}
        }
        /// <summary>
        /// 是否为用户默认地址枚举：（是=1，否=0）
        /// </summary>
        public Int32 IsDefault
        {
            set{ _isdefault=value;}
            get{return _isdefault;}
        }
        #endregion
	}
}
