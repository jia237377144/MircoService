/******************************************
* 模块名称：实体 必选区价格调节表
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
	/// 实体 必选区价格调节表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_require_price
	{
        #region 构造函数
        /// <summary>
        /// 实体 必选区价格调节表
        /// </summary>
        public product_spu_require_price(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _requirekeyid = Int32.MinValue;
        private Int32 _requirevalueid = Int32.MinValue;
        private decimal _price = decimal.MinValue;
        private Int32 _isdefault = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
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
        /// SPUID，外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// RequireKeyID，外键ID
        /// </summary>
        public Int32 RequireKeyID
        {
            set{ _requirekeyid=value;}
            get{return _requirekeyid;}
        }
        /// <summary>
        /// RequireValueID,外键ID
        /// </summary>
        public Int32 RequireValueID
        {
            set{ _requirevalueid=value;}
            get{return _requirevalueid;}
        }
        /// <summary>
        /// 必选区调节的价格
        /// </summary>
        public decimal Price
        {
            set{ _price=value;}
            get{return _price;}
        }
        /// <summary>
        /// 是否默认(1：默认)
        /// </summary>
        public Int32 IsDefault
        {
            set{ _isdefault=value;}
            get{return _isdefault;}
        }
        /// <summary>
        /// 启用状态(1：启用，0：禁用)
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 排序值
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        #endregion
	}
}
