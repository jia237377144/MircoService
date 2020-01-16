/******************************************
* 模块名称：实体 商品加价购
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
	/// 实体 商品加价购
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_price_increase
	{
        #region 构造函数
        /// <summary>
        /// 实体 商品加价购
        /// </summary>
        public product_price_increase(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private string _name = null;
        private string _culturejson = null;
        private string _platformjson = null;
        private Int32 _limittype = Int32.MinValue;
        private string _limittvaluejson = null;
        private decimal _limitprice = decimal.MinValue;
        private Int32 _limitusertype = Int32.MinValue;
        private decimal _sellprice = decimal.MinValue;
        private Int32 _stock = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private DateTime _begintime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// 加价购名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 多语言JSON
        /// </summary>
        public string CultureJSON
        {
            set{ _culturejson=value;}
            get{return _culturejson;}
        }
        /// <summary>
        /// 枚举:类目显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 限制类型枚举：1：类目，2：品类
        /// </summary>
        public Int32 LimitType
        {
            set{ _limittype=value;}
            get{return _limittype;}
        }
        /// <summary>
        /// 限制类型JSON值
        /// </summary>
        public string LimittValueJSON
        {
            set{ _limittvaluejson=value;}
            get{return _limittvaluejson;}
        }
        /// <summary>
        /// 限制金额
        /// </summary>
        public decimal LimitPrice
        {
            set{ _limitprice=value;}
            get{return _limitprice;}
        }
        /// <summary>
        /// 限制用户类型枚举类型
        /// </summary>
        public Int32 LimitUserType
        {
            set{ _limitusertype=value;}
            get{return _limitusertype;}
        }
        /// <summary>
        /// 加价购售价
        /// </summary>
        public decimal SellPrice
        {
            set{ _sellprice=value;}
            get{return _sellprice;}
        }
        /// <summary>
        /// 库存
        /// </summary>
        public Int32 Stock
        {
            set{ _stock=value;}
            get{return _stock;}
        }
        /// <summary>
        /// 排序值
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime
        {
            set{ _begintime=value;}
            get{return _begintime;}
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
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
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        #endregion
	}
}
