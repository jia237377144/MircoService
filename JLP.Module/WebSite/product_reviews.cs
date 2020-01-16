/******************************************
* 模块名称：实体 产品评论
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
	/// 实体 产品评论
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_reviews
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品评论
        /// </summary>
        public product_reviews(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _useremail = null;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _platform = Int32.MinValue;
        private DateTime _addtime = DateTime.MinValue;
        private string _content = null;
        private string _userip = null;
        private Int32 _status = Int32.MinValue;
        private string _imagesjson = null;
        private Int32 _productqualitylevel = Int32.MinValue;
        private Int32 _shippingspeedlevel = Int32.MinValue;
        private Int32 _customersatisfylevel = Int32.MinValue;
        private Int32 _ishaveimage = Int32.MinValue;
        private Int32 _categoryreviewitemid = Int32.MinValue;
        private Int32 _isshowusersize = Int32.MinValue;
        private Int32 _reviewsource = Int32.MinValue;
        private Int32 _replycustomerid = Int32.MinValue;
        private string _replycustomername = null;
        private string _replycustomercontent = null;
        private string _replycustomeremail = null;
        private DateTime _replycustomertime = DateTime.MinValue;
        private Int32 _replystatus = Int32.MinValue;
        private Int32 _responsibleadminid = Int32.MinValue;
        private string _responsibleadminemail = null;
        private string _responsibleadminname = null;
        private Int32 _recommendstatus = Int32.MinValue;
        private Int32 _usefulcount = Int32.MinValue;
        private Int32 _uselesscount = Int32.MinValue;
        private Int32 _pushstatus = Int32.MinValue;
        private DateTime _pushtime = DateTime.MinValue;
        private string _pushadminname = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
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
        /// 用户邮箱地址
        /// </summary>
        public string UserEmail
        {
            set{ _useremail=value;}
            get{return _useremail;}
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
        /// 产品URL的ID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
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
        /// 评论添加时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content
        {
            set{ _content=value;}
            get{return _content;}
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
        /// 评论状态，枚举类型
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 评论图片JSON
        /// </summary>
        public string ImagesJSON
        {
            set{ _imagesjson=value;}
            get{return _imagesjson;}
        }
        /// <summary>
        /// 产品质量级别(CommodityQuality)
        /// </summary>
        public Int32 ProductQualityLevel
        {
            set{ _productqualitylevel=value;}
            get{return _productqualitylevel;}
        }
        /// <summary>
        /// 配送速度级别(ShippingSpeed)
        /// </summary>
        public Int32 ShippingSpeedLevel
        {
            set{ _shippingspeedlevel=value;}
            get{return _shippingspeedlevel;}
        }
        /// <summary>
        /// 客服满意度级别(CustomerQuality)
        /// </summary>
        public Int32 CustomerSatisfyLevel
        {
            set{ _customersatisfylevel=value;}
            get{return _customersatisfylevel;}
        }
        /// <summary>
        /// 是否有评论图片，枚举类型
        /// </summary>
        public Int32 IsHaveImage
        {
            set{ _ishaveimage=value;}
            get{return _ishaveimage;}
        }
        /// <summary>
        /// 品类评论选项标识ID
        /// </summary>
        public Int32 CategoryReviewItemID
        {
            set{ _categoryreviewitemid=value;}
            get{return _categoryreviewitemid;}
        }
        /// <summary>
        /// 是否显示用户尺码信息
        /// </summary>
        public Int32 IsShowUserSize
        {
            set{ _isshowusersize=value;}
            get{return _isshowusersize;}
        }
        /// <summary>
        /// 评论来源(枚举类型：用户，系统导入)
        /// </summary>
        public Int32 ReviewSource
        {
            set{ _reviewsource=value;}
            get{return _reviewsource;}
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
        /// 负责人ID
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
        /// <summary>
        /// 推荐状态（枚举类型：1:推荐，0:未推荐）
        /// </summary>
        public Int32 RecommendStatus
        {
            set{ _recommendstatus=value;}
            get{return _recommendstatus;}
        }
        /// <summary>
        /// 有用数
        /// </summary>
        public Int32 UseFulCount
        {
            set{ _usefulcount=value;}
            get{return _usefulcount;}
        }
        /// <summary>
        /// 无用数
        /// </summary>
        public Int32 UseLessCount
        {
            set{ _uselesscount=value;}
            get{return _uselesscount;}
        }
        /// <summary>
        /// 推送状态
        /// </summary>
        public Int32 PushStatus
        {
            set{ _pushstatus=value;}
            get{return _pushstatus;}
        }
        /// <summary>
        /// 推送时间
        /// </summary>
        public DateTime PushTime
        {
            set{ _pushtime=value;}
            get{return _pushtime;}
        }
        /// <summary>
        /// 评论推送管理员人名
        /// </summary>
        public string PushAdminName
        {
            set{ _pushadminname=value;}
            get{return _pushadminname;}
        }
        #endregion
	}
}
