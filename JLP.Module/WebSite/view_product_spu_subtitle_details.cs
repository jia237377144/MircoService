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
	public class view_product_spu_subtitle_details
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_subtitle_details(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _subtitlecategoryid = Int32.MinValue;
        private string _cultureidjson = null;
        private string _platformjson = null;
        private Int32 _type = Int32.MinValue;
        private string _typevaluejson = null;
        private DateTime _begintime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private string _remark = null;
        private Int32 _masterstatus = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _categoryname = null;
        private Int32 _parentid = Int32.MinValue;
        private Int32 _categorystatus = Int32.MinValue;
        private Int32 _typevalue = Int32.MinValue;
        private Int32 _detailstatus = Int32.MinValue;
        private Int32 _detailid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _subtitle = null;
        private string _url = null;
        private Int32 _culturepartid = Int32.MinValue;
        private Int32 _culturepartstatus = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 副标题类别ID,外键ID
        /// </summary>
        public Int32 SubTitleCategoryID
        {
            set{ _subtitlecategoryid=value;}
            get{return _subtitlecategoryid;}
        }
        /// <summary>
        /// 多语言JSON值,标记哪些语言可以有副标题,否则就不允许添加对应多语言。
        /// </summary>
        public string CultureIDJSON
        {
            set{ _cultureidjson=value;}
            get{return _cultureidjson;}
        }
        /// <summary>
        /// 枚举:副标题显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 类型枚举[1SPUID,2类目]
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 类型值JSON
        /// </summary>
        public string TypeValueJSON
        {
            set{ _typevaluejson=value;}
            get{return _typevaluejson;}
        }
        /// <summary>
        /// 副标题开始使用时间
        /// </summary>
        public DateTime BeginTime
        {
            set{ _begintime=value;}
            get{return _begintime;}
        }
        /// <summary>
        /// 副标题停止使用时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set{ _remark=value;}
            get{return _remark;}
        }
        /// <summary>
        /// 状态枚举[0删除,1正常]
        /// </summary>
        public Int32 MasterStatus
        {
            set{ _masterstatus=value;}
            get{return _masterstatus;}
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
        /// 副标题类别名称
        /// </summary>
        public string CategoryName
        {
            set{ _categoryname=value;}
            get{return _categoryname;}
        }
        /// <summary>
        /// 父分类ID[暂时不用,默认全部是0]
        /// </summary>
        public Int32 ParentID
        {
            set{ _parentid=value;}
            get{return _parentid;}
        }
        /// <summary>
        /// 状态枚举[0删除,1正常]
        /// </summary>
        public Int32 CategoryStatus
        {
            set{ _categorystatus=value;}
            get{return _categorystatus;}
        }
        /// <summary>
        /// 类型值[如果是主表选的是A,B两个类目,这个表会有两个记录,A和B,SpuId和类目一样。方便前台查询]
        /// </summary>
        public Int32 TypeValue
        {
            set{ _typevalue=value;}
            get{return _typevalue;}
        }
        /// <summary>
        /// 状态枚举[0删除,1正常],有可能和主表不一致,因为主表可以编辑类型值,会添加和删除。
        /// </summary>
        public Int32 DetailStatus
        {
            set{ _detailstatus=value;}
            get{return _detailstatus;}
        }
        /// <summary>
        /// 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 DetailID
        {
            set{ _detailid=value;}
            get{return _detailid;}
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
        /// 副标题内容
        /// </summary>
        public string SubTitle
        {
            set{ _subtitle=value;}
            get{return _subtitle;}
        }
        /// <summary>
        /// 副标题的链接地址
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 CulturePartID
        {
            set{ _culturepartid=value;}
            get{return _culturepartid;}
        }
        /// <summary>
        /// 状态枚举[0删除,1正常],有可能和主表不一致,因为主表可以编辑语言值,会添加和删除。
        /// </summary>
        public Int32 CulturePartStatus
        {
            set{ _culturepartstatus=value;}
            get{return _culturepartstatus;}
        }
        #endregion
	}
}
