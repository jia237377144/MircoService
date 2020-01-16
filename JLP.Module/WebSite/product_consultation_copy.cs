/******************************************
* 模块名称：实体 产品咨询表
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
	/// 实体 产品咨询表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_consultation_copy
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品咨询表
        /// </summary>
        public product_consultation_copy(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _useremail = null;
        private string _username = null;
        private string _userip = null;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _platform = Int32.MinValue;
        private Int32 _ordermasterid = Int32.MinValue;
        private Int32 _orderdetailid = Int32.MinValue;
        private Int32 _type = Int32.MinValue;
        private string _content = null;
        private DateTime _addtime = DateTime.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _replycustomerid = Int32.MinValue;
        private string _replycustomername = null;
        private string _replycustomercontent = null;
        private string _replycustomeremail = null;
        private DateTime _replycustomertime = DateTime.MinValue;
        private Int32 _replystatus = Int32.MinValue;
        private Int32 _responsibleadminid = Int32.MinValue;
        private string _responsibleadminemail = null;
        private string _responsibleadminname = null;
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
        /// 用户ID，外键ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserEmail
        {
            set{ _useremail=value;}
            get{return _useremail;}
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            set{ _username=value;}
            get{return _username;}
        }
        /// <summary>
        /// 用户IP地址
        /// </summary>
        public string UserIP
        {
            set{ _userip=value;}
            get{return _userip;}
        }
        /// <summary>
        /// PID，外键ID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
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
        /// SKUID，外键ID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 评论平台，枚举类型
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
        }
        /// <summary>
        /// 订单ID，外键ID，当咨询类型为订单咨询时有数据（暂时不会用到）
        /// </summary>
        public Int32 OrderMasterID
        {
            set{ _ordermasterid=value;}
            get{return _ordermasterid;}
        }
        /// <summary>
        /// 子单ID，外键ID，当咨询类型为订单咨询时有数据（暂时不会用到）
        /// </summary>
        public Int32 OrderDetailID
        {
            set{ _orderdetailid=value;}
            get{return _orderdetailid;}
        }
        /// <summary>
        /// 咨询类型（枚举类型，产品咨询、运输时间咨询、订单咨询等。暂时不会用到，后面其他站会用到）
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 咨询内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// 咨询添加时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        /// <summary>
        /// 咨询状态，枚举类型
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 客服编号ID，外键ID
        /// </summary>
        public Int32 ReplyCustomerID
        {
            set{ _replycustomerid=value;}
            get{return _replycustomerid;}
        }
        /// <summary>
        /// 客服名称
        /// </summary>
        public string ReplyCustomerName
        {
            set{ _replycustomername=value;}
            get{return _replycustomername;}
        }
        /// <summary>
        /// 客服回复内容
        /// </summary>
        public string ReplyCustomerContent
        {
            set{ _replycustomercontent=value;}
            get{return _replycustomercontent;}
        }
        /// <summary>
        /// 客服邮箱地址
        /// </summary>
        public string ReplyCustomerEmail
        {
            set{ _replycustomeremail=value;}
            get{return _replycustomeremail;}
        }
        /// <summary>
        /// 客服回复时间
        /// </summary>
        public DateTime ReplyCustomerTime
        {
            set{ _replycustomertime=value;}
            get{return _replycustomertime;}
        }
        /// <summary>
        /// 回复状态(枚举类型：未回复，已回复)
        /// </summary>
        public Int32 ReplyStatus
        {
            set{ _replystatus=value;}
            get{return _replystatus;}
        }
        /// <summary>
        /// 负责人ID，外键ID
        /// </summary>
        public Int32 ResponsibleAdminID
        {
            set{ _responsibleadminid=value;}
            get{return _responsibleadminid;}
        }
        /// <summary>
        /// 负责人邮箱
        /// </summary>
        public string ResponsibleAdminEmail
        {
            set{ _responsibleadminemail=value;}
            get{return _responsibleadminemail;}
        }
        /// <summary>
        /// 负责人名称
        /// </summary>
        public string ResponsibleAdminName
        {
            set{ _responsibleadminname=value;}
            get{return _responsibleadminname;}
        }
        #endregion
	}
}
