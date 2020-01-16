/******************************************
* 模块名称：实体 专题产品聚合
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
	/// 实体 专题产品聚合
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_product_aggregation
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题产品聚合
        /// </summary>
        public topic_product_aggregation(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _labelid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private Int32 _moduleid = Int32.MinValue;
        private string _name = null;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _scopetype = Int32.MinValue;
        private string _platformjson = null;
        private string _leimuorcategoryjson = null;
        private string _productproperty = null;
        private Int32 _salesmark = Int32.MinValue;
        private Int32 _salesvalue = Int32.MinValue;
        private Int32 _browsemark = Int32.MinValue;
        private Int32 _browsevalue = Int32.MinValue;
        private Int32 _newtimevalue = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private string _lastupdatecontent = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
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
        /// 专题ID，外键ID
        /// </summary>
        public Int32 InfoID
        {
            set{ _infoid=value;}
            get{return _infoid;}
        }
        /// <summary>
        /// 标签ID，外键ID
        /// </summary>
        public Int32 LabelID
        {
            set{ _labelid=value;}
            get{return _labelid;}
        }
        /// <summary>
        /// 位置ID，外键ID
        /// </summary>
        public Int32 PositionID
        {
            set{ _positionid=value;}
            get{return _positionid;}
        }
        /// <summary>
        /// 模块ID，关联一个模块内的标签、产品、图片等
        /// </summary>
        public Int32 ModuleID
        {
            set{ _moduleid=value;}
            get{return _moduleid;}
        }
        /// <summary>
        /// 规则名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
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
        /// 作用类型,枚举
        /// </summary>
        public Int32 ScopeType
        {
            set{ _scopetype=value;}
            get{return _scopetype;}
        }
        /// <summary>
        /// 广告使用平台枚举：PC，M，APP
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 可配置的多个类目或者可配置的多个品类 例如[456875,452669] 
        /// </summary>
        public string LeiMuOrCategoryJSON
        {
            set{ _leimuorcategoryjson=value;}
            get{return _leimuorcategoryjson;}
        }
        /// <summary>
        /// 产品属性
        /// </summary>
        public string ProductProperty
        {
            set{ _productproperty=value;}
            get{return _productproperty;}
        }
        /// <summary>
        /// 销量符号,枚举
        /// </summary>
        public Int32 SalesMark
        {
            set{ _salesmark=value;}
            get{return _salesmark;}
        }
        /// <summary>
        /// 销量值
        /// </summary>
        public Int32 SalesValue
        {
            set{ _salesvalue=value;}
            get{return _salesvalue;}
        }
        /// <summary>
        /// 浏览符号,枚举
        /// </summary>
        public Int32 BrowseMark
        {
            set{ _browsemark=value;}
            get{return _browsemark;}
        }
        /// <summary>
        /// 浏览值
        /// </summary>
        public Int32 BrowseValue
        {
            set{ _browsevalue=value;}
            get{return _browsevalue;}
        }
        /// <summary>
        /// 上新时间，往前推的天数
        /// </summary>
        public Int32 NewTimeValue
        {
            set{ _newtimevalue=value;}
            get{return _newtimevalue;}
        }
        /// <summary>
        /// 规则状态，0-禁用，1-启用
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 排序
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 最后一个编辑人的修改内容
        /// </summary>
        public string LastUpdateContent
        {
            set{ _lastupdatecontent=value;}
            get{return _lastupdatecontent;}
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
