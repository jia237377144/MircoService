/******************************************
* 模块名称：实体 SKU修改信息触发器跟踪记录
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
	/// 实体 SKU修改信息触发器跟踪记录
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku_modify_trigger
	{
        #region 构造函数
        /// <summary>
        /// 实体 SKU修改信息触发器跟踪记录
        /// </summary>
        public product_sku_modify_trigger(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _formulamasterid = Int32.MinValue;
        private decimal _price = decimal.MinValue;
        private Int32 _type = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private string _createusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键自增(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SPUID，外键
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID，外键
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// FormulaMasterID
        /// </summary>
        public Int32 FormulaMasterID
        {
            set{ _formulamasterid=value;}
            get{return _formulamasterid;}
        }
        /// <summary>
        /// 调整的价格(新价格)
        /// </summary>
        public decimal Price
        {
            set{ _price=value;}
            get{return _price;}
        }
        /// <summary>
        /// 调整枚举：基础价、售卖价、活动价
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
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
        /// CreateUserName
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        #endregion
	}
}
