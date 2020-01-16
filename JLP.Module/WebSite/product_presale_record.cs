/******************************************
* 模块名称：实体 产品试款记录
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
	/// 实体 产品试款记录
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_presale_record
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品试款记录
        /// </summary>
        public product_presale_record(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _specificationcode = null;
        private string _specificationtext = null;
        private Int32 _userid = Int32.MinValue;
        private string _userguid = null;
        private string _subscribeemail = null;
        private string _ipaddress = null;
        private Int32 _platform = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private DateTime _intopresale = DateTime.MinValue;
        private string _deviceid = null;
        private string _devicetoken = null;
        private Int32 _devicetype = Int32.MinValue;
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
        /// 产品SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
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
        /// 用户ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 用户唯一标示
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
        public DateTime InToPresale
        {
            set{ _intopresale=value;}
            get{return _intopresale;}
        }
        /// <summary>
        /// DeviceID
        /// </summary>
        public string DeviceID
        {
            set{ _deviceid=value;}
            get{return _deviceid;}
        }
        /// <summary>
        /// DeviceToken
        /// </summary>
        public string DeviceToken
        {
            set{ _devicetoken=value;}
            get{return _devicetoken;}
        }
        /// <summary>
        /// DeviceType
        /// </summary>
        public Int32 DeviceType
        {
            set{ _devicetype=value;}
            get{return _devicetype;}
        }
        #endregion
	}
}
