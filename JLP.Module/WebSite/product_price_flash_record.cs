/******************************************
* 模块名称：实体 商品闪购销售记录
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
	/// 实体 商品闪购销售记录
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_price_flash_record
	{
        #region 构造函数
        /// <summary>
        /// 实体 商品闪购销售记录
        /// </summary>
        public product_price_flash_record(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _priceflashid = Int32.MinValue;
        private Int32 _priceflashdetailid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private string _specificationcode = null;
        private string _specificationtext = null;
        private Int32 _userid = Int32.MinValue;
        private string _userguid = null;
        private string _subscribeemail = null;
        private string _ipaddress = null;
        private Int32 _platform = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private DateTime _addtime = DateTime.MinValue;
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
        /// 商品闪购主表ID，外键ID
        /// </summary>
        public Int32 PriceFlashID
        {
            set{ _priceflashid=value;}
            get{return _priceflashid;}
        }
        /// <summary>
        /// 商品闪购明细表ID，外键ID
        /// </summary>
        public Int32 PriceFlashDetailID
        {
            set{ _priceflashdetailid=value;}
            get{return _priceflashdetailid;}
        }
        /// <summary>
        /// 多语言ID，外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
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
        /// 规格编码（选中的必选区键值对）。如：2014=456&2015=3654&856=451
        /// </summary>
        public string SpecificationCode
        {
            set{ _specificationcode=value;}
            get{return _specificationcode;}
        }
        /// <summary>
        /// 规格文本
        /// </summary>
        public string SpecificationText
        {
            set{ _specificationtext=value;}
            get{return _specificationtext;}
        }
        /// <summary>
        /// 用户ID，外键ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string UserGuid
        {
            set{ _userguid=value;}
            get{return _userguid;}
        }
        /// <summary>
        /// 用户订阅的邮箱
        /// </summary>
        public string SubscribeEmail
        {
            set{ _subscribeemail=value;}
            get{return _subscribeemail;}
        }
        /// <summary>
        /// 用户预定时的IP地址
        /// </summary>
        public string IPAddress
        {
            set{ _ipaddress=value;}
            get{return _ipaddress;}
        }
        /// <summary>
        /// 平台
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
        }
        /// <summary>
        /// 记录状态，1有效，0无效
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        #endregion
	}
}
