/******************************************
* 模块名称：实体 订单退换货原因多语言信息表
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
	/// 实体 订单退换货原因多语言信息表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class order_exchange_reason_culture
	{
        #region 构造函数
        /// <summary>
        /// 实体 订单退换货原因多语言信息表
        /// </summary>
        public order_exchange_reason_culture(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _cmsid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _exchangetypejson = null;
        private string _orderdetailstatejson = null;
        private string _categoryidjson = null;
        private string _content = null;
        private Int32 _sort = Int32.MinValue;
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
        /// CMS传过来的ID
        /// </summary>
        public Int32 CMSID
        {
            set{ _cmsid=value;}
            get{return _cmsid;}
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
        /// 退换货类型枚举JSON:[1,2,3]
        /// </summary>
        public string ExchangeTypeJSON
        {
            set{ _exchangetypejson=value;}
            get{return _exchangetypejson;}
        }
        /// <summary>
        /// 子单状态枚举JSON:[1,2,3]
        /// </summary>
        public string OrderDetailStateJSON
        {
            set{ _orderdetailstatejson=value;}
            get{return _orderdetailstatejson;}
        }
        /// <summary>
        /// 品类ID集合JSON
        /// </summary>
        public string CategoryIDJSON
        {
            set{ _categoryidjson=value;}
            get{return _categoryidjson;}
        }
        /// <summary>
        /// 原因内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
        }
        /// <summary>
        /// 排序值
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 有效性
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        #endregion
	}
}
