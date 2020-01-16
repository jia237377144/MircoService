/******************************************
* 模块名称：实体 产品副标题主表
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
	/// 实体 产品副标题主表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_subtitle_master
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品副标题主表
        /// </summary>
        public product_spu_subtitle_master(){}
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
        private Int32 _status = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键，自增ID(NOT NULL)
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
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
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
