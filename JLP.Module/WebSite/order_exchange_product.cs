/******************************************
* 模块名称：实体 订单退换货产品信息表
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
	/// 实体 订单退换货产品信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_exchange_product
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单退换货产品信息表
        /// </summary>
        public order_exchange_product(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _parentid = Int32.MinValue;
        private Int32 _exchangetype = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _employeeid = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _orderdetailid = Int32.MinValue;
        private Int32 _exchangeneworderdetailid = Int32.MinValue;
        private Int32 _exchangeorderdetailstate = Int32.MinValue;
        private Int32 _reasonid = Int32.MinValue;
        private decimal _realrequestrefundprice = decimal.MinValue;
        private Int32 _auditortype = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _content = null;
        private string _attachurl = null;
        private string _phone = null;
        private string _expressusername = null;
        private string _expressname = null;
        private string _expressno = null;
        private string _address = null;
        private string _postcode = null;
        private Int32 _status = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
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
        /// 后端回执ID，用户发的都是0，客服发的都是ID字段值。
        /// </summary>
        public Int32 ParentID
        {
            set{ _parentid=value;}
            get{return _parentid;}
        }
        /// <summary>
        /// 退换货枚举类型（1退款、2退货、3换货）
        /// </summary>
        public Int32 ExchangeType
        {
            set{ _exchangetype=value;}
            get{return _exchangetype;}
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
        /// 客服ID，外键ID
        /// </summary>
        public Int32 EmployeeID
        {
            set{ _employeeid=value;}
            get{return _employeeid;}
        }
        /// <summary>
        /// 主订单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 子订单ID，外键ID
        /// </summary>
        public Int32 OrderDetailID
        {
            set{ _orderdetailid=value;}
            get{return _orderdetailid;}
        }
        /// <summary>
        /// 换货成功新子单ID
        /// </summary>
        public Int32 ExchangeNewOrderDetailID
        {
            set{ _exchangeneworderdetailid=value;}
            get{return _exchangeneworderdetailid;}
        }
        /// <summary>
        /// 退换货子单状态,来源于order_detail表ExchangeOrderDetailState列
        /// </summary>
        public Int32 ExchangeOrderDetailState
        {
            set{ _exchangeorderdetailstate=value;}
            get{return _exchangeorderdetailstate;}
        }
        /// <summary>
        /// 退换货原因ID，外键ID
        /// </summary>
        public Int32 ReasonID
        {
            set{ _reasonid=value;}
            get{return _reasonid;}
        }
        /// <summary>
        /// 真实请求退换货产品或加运费的金额
        /// </summary>
        public decimal RealRequestRefundPrice
        {
            set{ _realrequestrefundprice=value;}
            get{return _realrequestrefundprice;}
        }
        /// <summary>
        /// 后端审核结果
        /// </summary>
        public Int32 AuditorType
        {
            set{ _auditortype=value;}
            get{return _auditortype;}
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
        /// 退换货沟通内容记录
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// 退换货申请凭据
        /// </summary>
        public string AttachURL
        {
            set{ _attachurl=value;}
            get{return _attachurl;}
        }
        /// <summary>
        /// 客户电话或者客服电话，根据ReturnID判断
        /// </summary>
        public string Phone
        {
            set{ _phone=value;}
            get{return _phone;}
        }
        /// <summary>
        /// 用户寄回货物的收货人名称
        /// </summary>
        public string ExpressUserName
        {
            set{ _expressusername=value;}
            get{return _expressusername;}
        }
        /// <summary>
        /// 用户寄回货物的快递名称
        /// </summary>
        public string ExpressName
        {
            set{ _expressname=value;}
            get{return _expressname;}
        }
        /// <summary>
        /// 用户寄回货物的快递编号
        /// </summary>
        public string ExpressNo
        {
            set{ _expressno=value;}
            get{return _expressno;}
        }
        /// <summary>
        /// 用户寄回货物的收货地址
        /// </summary>
        public string Address
        {
            set{ _address=value;}
            get{return _address;}
        }
        /// <summary>
        /// 用户寄回货物的收货邮编
        /// </summary>
        public string PostCode
        {
            set{ _postcode=value;}
            get{return _postcode;}
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
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        #endregion
	}
}
