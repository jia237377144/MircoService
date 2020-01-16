/******************************************
* 模块名称：实体 专题seo信息
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
	/// 实体 专题seo信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_seo
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题seo信息
        /// </summary>
        public topic_seo(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _metatitle = null;
        private string _metakeywords = null;
        private string _metadescription = null;
        private string _alternatehref = null;
        private string _bodydescription = null;
        private Int32 _status = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
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
        /// 专题信息ID，外键ID
        /// </summary>
        public Int32 InfoID
        {
            set{ _infoid=value;}
            get{return _infoid;}
        }
        /// <summary>
        /// 广告位ID，枚举类型ID
        /// </summary>
        public Int32 PositionID
        {
            set{ _positionid=value;}
            get{return _positionid;}
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
        /// Meta多语言标题信息
        /// </summary>
        public string MetaTitle
        {
            set{ _metatitle=value;}
            get{return _metatitle;}
        }
        /// <summary>
        /// Meta多语言关键字信息
        /// </summary>
        public string MetaKeywords
        {
            set{ _metakeywords=value;}
            get{return _metakeywords;}
        }
        /// <summary>
        /// Meta多语言描述信息
        /// </summary>
        public string MetaDescription
        {
            set{ _metadescription=value;}
            get{return _metadescription;}
        }
        /// <summary>
        /// html head link tag alternate href
        /// </summary>
        public string AlternateHref
        {
            set{ _alternatehref=value;}
            get{return _alternatehref;}
        }
        /// <summary>
        /// 页面多语言描述信息
        /// </summary>
        public string BodyDescription
        {
            set{ _bodydescription=value;}
            get{return _bodydescription;}
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
