/******************************************
* 模块名称：实体 产品SPU
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
	/// 实体 产品SPU
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品SPU
        /// </summary>
        public product_spu(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private string _brand = null;
        private Int32 _brandid = Int32.MinValue;
        private Int32 _imitationlevel = Int32.MinValue;
        private Int32 _shelfstatus = Int32.MinValue;
        private Int32 _lockstatus = Int32.MinValue;
        private Int32 _sourcetype = Int32.MinValue;
        private string _sourcevalue = null;
        private string _supplierproductcode = null;
        private Int32 _leadtimemin = Int32.MinValue;
        private Int32 _leadtimemax = Int32.MinValue;
        private decimal _costprice = decimal.MinValue;
        private Int32 _qualitylevel = Int32.MinValue;
        private Int32 _imagecount = Int32.MinValue;
        private Int32 _culturecount = Int32.MinValue;
        private Int32 _cancustomize = Int32.MinValue;
        private Int32 _netweight = Int32.MinValue;
        private Int32 _packageweight = Int32.MinValue;
        private Int32 _packagelength = Int32.MinValue;
        private Int32 _packagewidth = Int32.MinValue;
        private Int32 _packageheight = Int32.MinValue;
        private Int32 _ismulticolor = Int32.MinValue;
        private Int32 _defaultskuid = Int32.MinValue;
        private Int32 _ismote = Int32.MinValue;
        private Int32 _seriesid = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
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
        /// 品牌
        /// </summary>
        public string Brand
        {
            set{ _brand=value;}
            get{return _brand;}
        }
        /// <summary>
        /// 品牌ID
        /// </summary>
        public Int32 BrandID
        {
            set{ _brandid=value;}
            get{return _brandid;}
        }
        /// <summary>
        /// 仿货级别[枚举]:正品，一级，二级，三级
        /// </summary>
        public Int32 ImitationLevel
        {
            set{ _imitationlevel=value;}
            get{return _imitationlevel;}
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
        /// PMS产品锁定状态[枚举]：站点锁定、断货、侵权等
        /// </summary>
        public Int32 LockStatus
        {
            set{ _lockstatus=value;}
            get{return _lockstatus;}
        }
        /// <summary>
        /// 来源类型[枚举]:运营添加，网络抓取，供应商提供
        /// </summary>
        public Int32 SourceType
        {
            set{ _sourcetype=value;}
            get{return _sourcetype;}
        }
        /// <summary>
        /// 来源值
        /// </summary>
        public string SourceValue
        {
            set{ _sourcevalue=value;}
            get{return _sourcevalue;}
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
        /// 平均备货期 下限[单位:天]
        /// </summary>
        public Int32 LeadTimeMin
        {
            set{ _leadtimemin=value;}
            get{return _leadtimemin;}
        }
        /// <summary>
        /// 平均备货期 上限[单位：天]
        /// </summary>
        public Int32 LeadTimeMax
        {
            set{ _leadtimemax=value;}
            get{return _leadtimemax;}
        }
        /// <summary>
        /// 成本价(指导价格/参考价格)
        /// </summary>
        public decimal CostPrice
        {
            set{ _costprice=value;}
            get{return _costprice;}
        }
        /// <summary>
        /// 质量等级[枚举]：未知，优，良，中，差
        /// </summary>
        public Int32 QualityLevel
        {
            set{ _qualitylevel=value;}
            get{return _qualitylevel;}
        }
        /// <summary>
        /// 已上传图片数量，默认为0
        /// </summary>
        public Int32 ImageCount
        {
            set{ _imagecount=value;}
            get{return _imagecount;}
        }
        /// <summary>
        /// 翻译数量,默认为0
        /// </summary>
        public Int32 CultureCount
        {
            set{ _culturecount=value;}
            get{return _culturecount;}
        }
        /// <summary>
        /// 是否支持定制
        /// </summary>
        public Int32 CanCustomize
        {
            set{ _cancustomize=value;}
            get{return _cancustomize;}
        }
        /// <summary>
        /// 物品净重(参考值) [单位:克]
        /// </summary>
        public Int32 NetWeight
        {
            set{ _netweight=value;}
            get{return _netweight;}
        }
        /// <summary>
        /// 包装重量(参考值) [单位:克]
        /// </summary>
        public Int32 PackageWeight
        {
            set{ _packageweight=value;}
            get{return _packageweight;}
        }
        /// <summary>
        /// 包装长度(参考值) [单位:CM]
        /// </summary>
        public Int32 PackageLength
        {
            set{ _packagelength=value;}
            get{return _packagelength;}
        }
        /// <summary>
        /// 包装宽度(参考值) [单位:CM]
        /// </summary>
        public Int32 PackageWidth
        {
            set{ _packagewidth=value;}
            get{return _packagewidth;}
        }
        /// <summary>
        /// 包装高度(参考值) [单位:CM]
        /// </summary>
        public Int32 PackageHeight
        {
            set{ _packageheight=value;}
            get{return _packageheight;}
        }
        /// <summary>
        /// 是否多色枚举：（多色=1，不多色=0）
        /// </summary>
        public Int32 IsMultiColor
        {
            set{ _ismulticolor=value;}
            get{return _ismulticolor;}
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
        /// 是否含有模特信息,1有,0无
        /// </summary>
        public Int32 IsMote
        {
            set{ _ismote=value;}
            get{return _ismote;}
        }
        /// <summary>
        /// SeriesID
        /// </summary>
        public Int32 SeriesID
        {
            set{ _seriesid=value;}
            get{return _seriesid;}
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
        #endregion
	}
}
