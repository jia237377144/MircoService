/******************************************
* 模块名称：实体 worldpay
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
	/// 实体 worldpay
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_worldpay_token
	{
        #region 构造函数
        /// <summary>
        /// 实体 worldpay
        /// </summary>
        public order_worldpay_token(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _tokenid = null;
        private string _shopperid = null;
        private string _shopperemailaddress = null;
        private string _cardbrand = null;
        private string _cardsubbrand = null;
        private string _issuercountrycode = null;
        private string _obfuscatedpan = null;
        private string _transactionid = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private Int32 _status = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 我们自己创建，它收到后回传给我们。和worlderpay约定的令牌
        /// </summary>
        public string TokenID
        {
            set{ _tokenid=value;}
            get{return _tokenid;}
        }
        /// <summary>
        /// 购物人ID
        /// </summary>
        public string ShopperID
        {
            set{ _shopperid=value;}
            get{return _shopperid;}
        }
        /// <summary>
        /// 购物人邮箱
        /// </summary>
        public string ShopperEmailAddress
        {
            set{ _shopperemailaddress=value;}
            get{return _shopperemailaddress;}
        }
        /// <summary>
        /// worlderpay的卡类型
        /// </summary>
        public string Cardbrand
        {
            set{ _cardbrand=value;}
            get{return _cardbrand;}
        }
        /// <summary>
        /// worlderpay的卡子类型
        /// </summary>
        public string Cardsubbrand
        {
            set{ _cardsubbrand=value;}
            get{return _cardsubbrand;}
        }
        /// <summary>
        /// worlderpay的发卡国家代码
        /// </summary>
        public string IssuerCountryCode
        {
            set{ _issuercountrycode=value;}
            get{return _issuercountrycode;}
        }
        /// <summary>
        /// worlderpay的卡前后4位
        /// </summary>
        public string ObfuscatedPAN
        {
            set{ _obfuscatedpan=value;}
            get{return _obfuscatedpan;}
        }
        /// <summary>
        /// worlderpay的交易标识
        /// </summary>
        public string TransactionID
        {
            set{ _transactionid=value;}
            get{return _transactionid;}
        }
        /// <summary>
        /// 创建token时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// 修改token时间
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        #endregion
	}
}
