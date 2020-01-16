/******************************************
* 模块名称：实体 产品尺码表，只接收PMS传过来的数据。
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
	/// 实体 产品尺码表，只接收PMS传过来的数据。
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_sizetable
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品尺码表，只接收PMS传过来的数据。
        /// </summary>
        public product_spu_sizetable(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _sizetablejson = null;
        private Int32 _useddefault = Int32.MinValue;
        private Int32 _havedefault = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键,自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SPUID,外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 多语言ID,外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 尺码表JSON
        /// </summary>
        public string SizeTableJSON
        {
            set{ _sizetablejson=value;}
            get{return _sizetablejson;}
        }
        /// <summary>
        /// 是否使用品类上默认的尺码表
        /// </summary>
        public Int32 UsedDefault
        {
            set{ _useddefault=value;}
            get{return _useddefault;}
        }
        /// <summary>
        /// 是否包含默认项
        /// </summary>
        public Int32 HaveDefault
        {
            set{ _havedefault=value;}
            get{return _havedefault;}
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
