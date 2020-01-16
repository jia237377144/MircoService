/******************************************
* 模块名称：实体 预售类型介绍
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
	/// 实体 预售类型介绍
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class presale_type
	{
        #region 构造函数
        /// <summary>
        /// 实体 预售类型介绍
        /// </summary>
        public presale_type(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private Int32 _pretype = Int32.MinValue;
        private string _description = null;
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
        /// 预售类型名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 预售类型   EProduct_PreSaleType
        /// </summary>
        public Int32 PreType
        {
            set{ _pretype=value;}
            get{return _pretype;}
        }
        /// <summary>
        /// 预售类型描述
        /// </summary>
        public string Description
        {
            set{ _description=value;}
            get{return _description;}
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
