/******************************************
* 模块名称：实体 预售区间表
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
	/// 实体 预售区间表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class presale_range
	{
        #region 构造函数
        /// <summary>
        /// 实体 预售区间表
        /// </summary>
        public presale_range(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _presaleinfoid = Int32.MinValue;
        private Int32 _presalerangeconfigid = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _beginvalue = Int32.MinValue;
        private Int32 _endvalue = Int32.MinValue;
        private string _discountjson = null;
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
        /// preslae_info表的主键ID，外键ID
        /// </summary>
        public Int32 PreSaleInfoID
        {
            set{ _presaleinfoid=value;}
            get{return _presaleinfoid;}
        }
        /// <summary>
        /// presale_range_config表的主键ID，外键ID
        /// </summary>
        public Int32 PreSaleRangeConfigID
        {
            set{ _presalerangeconfigid=value;}
            get{return _presalerangeconfigid;}
        }
        /// <summary>
        /// 通用的状态枚举 EStatus
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 区间的起始值
        /// </summary>
        public Int32 BeginValue
        {
            set{ _beginvalue=value;}
            get{return _beginvalue;}
        }
        /// <summary>
        /// 区间的终止值
        /// </summary>
        public Int32 EndValue
        {
            set{ _endvalue=value;}
            get{return _endvalue;}
        }
        /// <summary>
        /// 优惠方式JSON，[{platform:1,discount:0.9,specifyPrice:15.8},{},{}]
        /// </summary>
        public string DiscountJSON
        {
            set{ _discountjson=value;}
            get{return _discountjson;}
        }
        #endregion
	}
}
