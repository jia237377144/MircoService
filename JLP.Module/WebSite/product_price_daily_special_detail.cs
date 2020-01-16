/******************************************
* 模块名称：实体 每日特价明细
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
	/// 实体 每日特价明细
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_price_daily_special_detail
	{
        #region 构造函数
        /// <summary>
        /// 实体 每日特价明细
        /// </summary>
        public product_price_daily_special_detail(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _dailyspecialid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _preferentialtype = Int32.MinValue;
        private string _preferentialvalue = null;
        private Int32 _stock = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
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
        /// 每日特价ID，外键ID
        /// </summary>
        public Int32 DailySpecialID
        {
            set{ _dailyspecialid=value;}
            get{return _dailyspecialid;}
        }
        /// <summary>
        /// PID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
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
        /// 优惠类型枚举:1.真实折扣 2.固定售价
        /// </summary>
        public Int32 PreferentialType
        {
            set{ _preferentialtype=value;}
            get{return _preferentialtype;}
        }
        /// <summary>
        /// 优惠值
        /// </summary>
        public string PreferentialValue
        {
            set{ _preferentialvalue=value;}
            get{return _preferentialvalue;}
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
        /// 排序
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
