/******************************************
* 模块名称：实体 网站自定义SPU显示信息，如果没有SPUID，需要使用Product_SPU的SPUID显示商品信息
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
	/// 实体 网站自定义SPU显示信息，如果没有SPUID，需要使用Product_SPU的SPUID显示商品信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_modify
	{
        #region 构造函数
        /// <summary>
        /// 实体 网站自定义SPU显示信息，如果没有SPUID，需要使用Product_SPU的SPUID显示商品信息
        /// </summary>
        public product_spu_modify(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _imagejson = null;
        private string _propertyjson = null;
        private string _requiredjson = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _render = Int32.MinValue;
        private string _platformjson = null;
        private DateTime _uptime = DateTime.MinValue;
        private DateTime _downtime = DateTime.MinValue;
        private Int32 _productid = Int32.MinValue;
        private Int32 _ishot = Int32.MinValue;
        private Int32 _ismutilcolor = Int32.MinValue;
        private Int32 _echelon = Int32.MinValue;
        private Int32 _defaultskuid = Int32.MinValue;
        private string _titleurl = null;
        private Int32 _offshelfreason = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SPUID（外键）
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 网站前台产品展示需要使用的所有图片ID的JSON[1,2,3,4,5]
        /// </summary>
        public string ImageJSON
        {
            set{ _imagejson=value;}
            get{return _imagejson;}
        }
        /// <summary>
        /// SPU自定制显示属性键和值JSON。[{kid:1,vid:[1,2]},{kid:11,vid:[11,22]}]
        /// </summary>
        public string PropertyJSON
        {
            set{ _propertyjson=value;}
            get{return _propertyjson;}
        }
        /// <summary>
        /// SPU自定制显示必选区键和值JSON。[{kid:1,display:1,vid:[1,2]},{kid:11,display:1,vid:[11,22]}]
        /// </summary>
        public string RequiredJSON
        {
            set{ _requiredjson=value;}
            get{return _requiredjson;}
        }
        /// <summary>
        /// SPU状态枚举（待编辑=0、下架=1、上架=2、定时上架=3）
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// SPU显示状态(显示=1，隐藏=0)
        /// </summary>
        public Int32 Render
        {
            set{ _render=value;}
            get{return _render;}
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
        /// 上架状态取系统时间，定时上架状态取UI时间
        /// </summary>
        public DateTime UpTime
        {
            set{ _uptime=value;}
            get{return _uptime;}
        }
        /// <summary>
        /// 下架时间（系统时间）
        /// </summary>
        public DateTime DownTime
        {
            set{ _downtime=value;}
            get{return _downtime;}
        }
        /// <summary>
        /// 老站产品ID，URL中用到
        /// </summary>
        public Int32 ProductID
        {
            set{ _productid=value;}
            get{return _productid;}
        }
        /// <summary>
        /// 是否热卖（1=热卖，0=不热卖）
        /// </summary>
        public Int32 IsHot
        {
            set{ _ishot=value;}
            get{return _ishot;}
        }
        /// <summary>
        /// 是否多色（1=多色，0=不多色）
        /// </summary>
        public Int32 IsMutilColor
        {
            set{ _ismutilcolor=value;}
            get{return _ismutilcolor;}
        }
        /// <summary>
        /// 产品梯队
        /// </summary>
        public Int32 Echelon
        {
            set{ _echelon=value;}
            get{return _echelon;}
        }
        /// <summary>
        /// 默认SKUID，可以取出首图颜色。
        /// </summary>
        public Int32 DefaultSKUID
        {
            set{ _defaultskuid=value;}
            get{return _defaultskuid;}
        }
        /// <summary>
        /// 网站产品页URL里面的标题名称
        /// </summary>
        public string TitleURL
        {
            set{ _titleurl=value;}
            get{return _titleurl;}
        }
        /// <summary>
        /// 下架原因,枚举值
        /// </summary>
        public Int32 OffShelfReason
        {
            set{ _offshelfreason=value;}
            get{return _offshelfreason;}
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
