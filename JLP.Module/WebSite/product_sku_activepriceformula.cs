/******************************************
* 模块名称：实体 SKU批量调整活动价格
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
	/// 实体 SKU批量调整活动价格
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sku_activepriceformula
	{
        #region 构造函数
        /// <summary>
        /// 实体 SKU批量调整活动价格
        /// </summary>
        public product_sku_activepriceformula(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private string _platformjson = null;
        private string _scopeuserleveljson = null;
        private string _typeidsjson = null;
        private string _typenamesjson = null;
        private Int32 _type = Int32.MinValue;
        private string _exculdespuidjson = null;
        private DateTime _begintime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private Int32 _discounttype = Int32.MinValue;
        private Int32 _discountrate = Int32.MinValue;
        private decimal _discountmoney = decimal.MinValue;
        private string _note = null;
        private Int32 _status = Int32.MinValue;
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
        /// 活动名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
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
        /// 会员等级JSON[1,2,3]
        /// </summary>
        public string ScopeUserLevelJSON
        {
            set{ _scopeuserleveljson=value;}
            get{return _scopeuserleveljson;}
        }
        /// <summary>
        /// TypeIDsJSON
        /// </summary>
        public string TypeIDsJSON
        {
            set{ _typeidsjson=value;}
            get{return _typeidsjson;}
        }
        /// <summary>
        /// TypeNamesJSON
        /// </summary>
        public string TypeNamesJSON
        {
            set{ _typenamesjson=value;}
            get{return _typenamesjson;}
        }
        /// <summary>
        /// 分类枚举：类目=1，品类=2，SPU=3
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 活动排除的SPUID集合JSON，仅在Type为类目或品类时使用
        /// </summary>
        public string ExculdeSPUIDJson
        {
            set{ _exculdespuidjson=value;}
            get{return _exculdespuidjson;}
        }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime BeginTime
        {
            set{ _begintime=value;}
            get{return _begintime;}
        }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
        }
        /// <summary>
        /// 优惠类型[折扣、减钱]
        /// </summary>
        public Int32 DiscountType
        {
            set{ _discounttype=value;}
            get{return _discounttype;}
        }
        /// <summary>
        /// 折扣率
        /// </summary>
        public Int32 DiscountRate
        {
            set{ _discountrate=value;}
            get{return _discountrate;}
        }
        /// <summary>
        /// 减钱金额
        /// </summary>
        public decimal DiscountMoney
        {
            set{ _discountmoney=value;}
            get{return _discountmoney;}
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note
        {
            set{ _note=value;}
            get{return _note;}
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
