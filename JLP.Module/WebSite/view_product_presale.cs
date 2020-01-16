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
	public class view_product_presale
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_presale(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _culturejson = null;
        private string _platformjson = null;
        private Int32 _isenable = Int32.MinValue;
        private Int32 _issendemail = Int32.MinValue;
        private Int32 _viewcount = Int32.MinValue;
        private Int32 _addcartcount = Int32.MinValue;
        private DateTime _sendemailtime = DateTime.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _endusername = null;
        private DateTime _enddatetime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _title = null;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private string _productimage = null;
        private long _emailcount = long.MinValue;
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
        /// 产品SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 多语言平台枚举
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
        /// 是否开启试款（1表示开启，0表示不开启）
        /// </summary>
        public Int32 IsEnable
        {
            set{ _isenable=value;}
            get{return _isenable;}
        }
        /// <summary>
        /// 是否发送到货通知
        /// </summary>
        public Int32 IsSendEmail
        {
            set{ _issendemail=value;}
            get{return _issendemail;}
        }
        /// <summary>
        /// 浏览量
        /// </summary>
        public Int32 ViewCount
        {
            set{ _viewcount=value;}
            get{return _viewcount;}
        }
        /// <summary>
        /// 添加购物车量
        /// </summary>
        public Int32 AddCartCount
        {
            set{ _addcartcount=value;}
            get{return _addcartcount;}
        }
        /// <summary>
        /// 发送到货通知时间
        /// </summary>
        public DateTime SendEmailTime
        {
            set{ _sendemailtime=value;}
            get{return _sendemailtime;}
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
        /// 终止人
        /// </summary>
        public string EndUserName
        {
            set{ _endusername=value;}
            get{return _endusername;}
        }
        /// <summary>
        /// 终止时间
        /// </summary>
        public DateTime EnddateTime
        {
            set{ _enddatetime=value;}
            get{return _enddatetime;}
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
        /// Title
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
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
        /// 品类ID (外键),PMS那里的品类ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// ProductImage
        /// </summary>
        public string ProductImage
        {
            set{ _productimage=value;}
            get{return _productimage;}
        }
        /// <summary>
        /// EmailCount
        /// </summary>
        public long EmailCount
        {
            set{ _emailcount=value;}
            get{return _emailcount;}
        }
        #endregion
	}
}
