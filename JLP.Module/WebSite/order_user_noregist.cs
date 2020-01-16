/******************************************
* 模块名称：实体 无注册用户购买生成订单
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
	/// 实体 无注册用户购买生成订单
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_user_noregist
	{
        #region 构造函数
        /// <summary>
        /// 实体 无注册用户购买生成订单
        /// </summary>
        public order_user_noregist(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
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
        /// 用户ID，外键ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 订单主单ID，外键ID
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        #endregion
	}
}
