/******************************************
* 模块名称：实体 VIEW
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
	/// 实体 VIEW
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class view_product_price_daily_special
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_price_daily_special(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _culturejson = null;
        private string _platformjson = null;
        private Int32 _producttype = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private DateTime _begintime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _spuid = null;
        private string _skuid = null;
        private Int32 _render = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键ID，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 多语言JSON
        /// </summary>
        public string CultureJSON
        {
            set{ _culturejson=value;}
            get{return _culturejson;}
        }
        /// <summary>
        /// 枚举:类目显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 产品类型枚举:1.SPU 2.SKU
        /// </summary>
        public Int32 ProductType
        {
            set{ _producttype=value;}
            get{return _producttype;}
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
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime
        {
            set{ _begintime=value;}
            get{return _begintime;}
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
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
        /// CreateTime
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
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
        /// SPUID
        /// </summary>
        public string SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID
        /// </summary>
        public string SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// Render
        /// </summary>
        public Int32 Render
        {
            set{ _render=value;}
            get{return _render;}
        }
        #endregion
	}
}
