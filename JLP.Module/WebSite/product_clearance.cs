/******************************************
* 模块名称：实体 产品清仓表
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
	/// 实体 产品清仓表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_clearance
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品清仓表
        /// </summary>
        public product_clearance(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _activepriceformulaid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
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
        /// 活动促销公式ID，外键ID
        /// </summary>
        public Int32 ActivePriceFormulaID
        {
            set{ _activepriceformulaid=value;}
            get{return _activepriceformulaid;}
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
        /// 通用的状态枚举 EStatus
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        #endregion
	}
}
