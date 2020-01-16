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
	public class view_product_spu_run
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_run(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _productprice = Int32.MinValue;
        private long _render = long.MinValue;
        private long _status = long.MinValue;
        private string _shelftime = null;
        private Int32 _categoryid = Int32.MinValue;
        private Int32 _shelfstatus = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _supplierproductcode = null;
        private DateTime _uptime = DateTime.MinValue;
        private string _platformjson = null;
        private Int32 _cultureid = Int32.MinValue;
        private string _leimuid = null;
        private string _email = null;
        private long _ishot = long.MinValue;
        private string _title = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 站点SPUID，网站前台URL中显示的产品ID，PMS传过来的
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// ProductPrice(NOT NULL)
        /// </summary>
        public Int32 ProductPrice
        {
            set{ _productprice=value;}
            get{return _productprice;}
        }
        /// <summary>
        /// Render
        /// </summary>
        public long Render
        {
            set{ _render=value;}
            get{return _render;}
        }
        /// <summary>
        /// Status
        /// </summary>
        public long Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// ShelfTime
        /// </summary>
        public string ShelfTime
        {
            set{ _shelftime=value;}
            get{return _shelftime;}
        }
        /// <summary>
        /// 品类ID (外键),PMS那里的品类ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 上架状态[枚举]：待上架、已上架、已下架
        /// </summary>
        public Int32 ShelfStatus
        {
            set{ _shelfstatus=value;}
            get{return _shelfstatus;}
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
        /// 供货商货号
        /// </summary>
        public string SupplierProductCode
        {
            set{ _supplierproductcode=value;}
            get{return _supplierproductcode;}
        }
        /// <summary>
        /// 上架状态取系统时间，定时上架状态取UI时间
        /// </summary>
        public DateTime UpTime
        {
            set{ _uptime=value;}
            get{return _uptime;}
        }
        /// <summary>
        /// 枚举：SPU显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 语言ID(外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// LeiMuID
        /// </summary>
        public string LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            set{ _email=value;}
            get{return _email;}
        }
        /// <summary>
        /// IsHot
        /// </summary>
        public long IsHot
        {
            set{ _ishot=value;}
            get{return _ishot;}
        }
        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        #endregion
	}
}
