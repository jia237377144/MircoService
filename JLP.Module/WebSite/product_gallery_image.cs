/******************************************
* 模块名称：实体 产品画廊图集
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
	/// 实体 产品画廊图集
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_gallery_image
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品画廊图集
        /// </summary>
        public product_gallery_image(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _productreviewid = Int32.MinValue;
        private string _samestylespuids = null;
        private string _similarstylespuids = null;
        private Int32 _styletype = Int32.MinValue;
        private Int32 _urlpathtype = Int32.MinValue;
        private string _urlpath = null;
        private Int32 _height = Int32.MinValue;
        private Int32 _width = Int32.MinValue;
        private Int32 _realgoodcount = Int32.MinValue;
        private Int32 _manualgoodcount = Int32.MinValue;
        private string _leimuidjson = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _gallerysourcetype = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// 产品评论ID，外键ID
        /// </summary>
        public Int32 ProductReviewID
        {
            set{ _productreviewid=value;}
            get{return _productreviewid;}
        }
        /// <summary>
        /// 同款产品SPUID数组，逗号分割
        /// </summary>
        public string SameStyleSPUIDs
        {
            set{ _samestylespuids=value;}
            get{return _samestylespuids;}
        }
        /// <summary>
        /// 相似款产品SPUID数组，逗号分割
        /// </summary>
        public string SimilarStyleSPUIDs
        {
            set{ _similarstylespuids=value;}
            get{return _similarstylespuids;}
        }
        /// <summary>
        /// 款式枚举类型（2：有多个同款、1：有一个同款、0：无同款）
        /// </summary>
        public Int32 StyleType
        {
            set{ _styletype=value;}
            get{return _styletype;}
        }
        /// <summary>
        /// 地址类型：EProduct_Gallery_Image_UrlPathType:0图片地址,1视频地址
        /// </summary>
        public Int32 UrlPathType
        {
            set{ _urlpathtype=value;}
            get{return _urlpathtype;}
        }
        /// <summary>
        /// 图片或者视频地址
        /// </summary>
        public string UrlPath
        {
            set{ _urlpath=value;}
            get{return _urlpath;}
        }
        /// <summary>
        /// Height
        /// </summary>
        public Int32 Height
        {
            set{ _height=value;}
            get{return _height;}
        }
        /// <summary>
        /// Width
        /// </summary>
        public Int32 Width
        {
            set{ _width=value;}
            get{return _width;}
        }
        /// <summary>
        /// 真实的点赞数
        /// </summary>
        public Int32 RealGoodCount
        {
            set{ _realgoodcount=value;}
            get{return _realgoodcount;}
        }
        /// <summary>
        /// 人工干预的点赞数
        /// </summary>
        public Int32 ManualGoodCount
        {
            set{ _manualgoodcount=value;}
            get{return _manualgoodcount;}
        }
        /// <summary>
        /// 类目IDJSON
        /// </summary>
        public string LeiMuIDJSON
        {
            set{ _leimuidjson=value;}
            get{return _leimuidjson;}
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
        /// 状态枚举EStatus
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 画廊来源枚举类型EProduct_Gallery_Image_GallerySourceType买家秀 = 0,
        /// </summary>
        public Int32 GallerySourceType
        {
            set{ _gallerysourcetype=value;}
            get{return _gallerysourcetype;}
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
