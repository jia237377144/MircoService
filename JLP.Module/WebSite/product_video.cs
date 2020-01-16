/******************************************
* 模块名称：实体 产品视频介绍
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
	/// 实体 产品视频介绍
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_video
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品视频介绍
        /// </summary>
        public product_video(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _videoid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _src = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _isdelete = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
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
        /// 视频ID，产品库传过来的D
        /// </summary>
        public Int32 VideoID
        {
            set{ _videoid=value;}
            get{return _videoid;}
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
        /// 视频对应地址，PMS对接
        /// </summary>
        public string Src
        {
            set{ _src=value;}
            get{return _src;}
        }
        /// <summary>
        /// 排序,对接PMS
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 是否删除,保留字段,PMS对接
        /// </summary>
        public Int32 IsDelete
        {
            set{ _isdelete=value;}
            get{return _isdelete;}
        }
        /// <summary>
        /// 网站视频启用状态(网站自己的)
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
