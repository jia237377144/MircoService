/******************************************
* 模块名称：实体 SKU批量调整售卖价格主表
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
	/// 实体 SKU批量调整售卖价格主表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku_sellpriceformula_master
	{
        #region 构造函数
        /// <summary>
        /// 实体 SKU批量调整售卖价格主表
        /// </summary>
        public product_sku_sellpriceformula_master(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _platformjson = null;
        private Int32 _type = Int32.MinValue;
        private string _typeidsjson = null;
        private string _typenamesjson = null;
        private Int32 _operatetype = Int32.MinValue;
        private string _description = null;
        private string _reason = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _pricetype = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键、自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 调价使用的平台
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 分类枚举：类目=1，品类=2
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 品类或类目ID集合JSON
        /// </summary>
        public string TypeIDsJSON
        {
            set{ _typeidsjson=value;}
            get{return _typeidsjson;}
        }
        /// <summary>
        /// 品类或类目名称集合JSON
        /// </summary>
        public string TypeNamesJSON
        {
            set{ _typenamesjson=value;}
            get{return _typenamesjson;}
        }
        /// <summary>
        /// 操作类型枚举：涨价=1，降价=2
        /// </summary>
        public Int32 OperateType
        {
            set{ _operatetype=value;}
            get{return _operatetype;}
        }
        /// <summary>
        /// 修改说明
        /// </summary>
        public string Description
        {
            set{ _description=value;}
            get{return _description;}
        }
        /// <summary>
        /// 修改原因
        /// </summary>
        public string Reason
        {
            set{ _reason=value;}
            get{return _reason;}
        }
        /// <summary>
        /// 状态枚举：待执行=0，已执行=1
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 调整价格公式枚举：只调整售卖价公式=0,同时调整售卖价和市场价公式=1,
        /// </summary>
        public Int32 PriceType
        {
            set{ _pricetype=value;}
            get{return _pricetype;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
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
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
