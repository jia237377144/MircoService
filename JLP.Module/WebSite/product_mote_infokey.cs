/******************************************
* 模块名称：实体 模特信息配置
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
	/// 实体 模特信息配置
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_mote_infokey
	{
        #region 构造函数
        /// <summary>
        /// 实体 模特信息配置
        /// </summary>
        public product_mote_infokey(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private string _categoryidjson = null;
        private Int32 _unit = Int32.MinValue;
        private Int32 _isrequired = Int32.MinValue;
        private Int32 _isenable = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 模特属性键ID，PMS传过来ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 属性键值，PMS传过来
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 对应设置品类，PMS传过来
        /// </summary>
        public string CategoryIDJSON
        {
            set{ _categoryidjson=value;}
            get{return _categoryidjson;}
        }
        /// <summary>
        /// 单位【1：cm 2：in 3:ft】，PMS传过来
        /// </summary>
        public Int32 Unit
        {
            set{ _unit=value;}
            get{return _unit;}
        }
        /// <summary>
        /// 是否必填项 ,PMS传过来
        /// </summary>
        public Int32 IsRequired
        {
            set{ _isrequired=value;}
            get{return _isrequired;}
        }
        /// <summary>
        /// 是否启用，PMS传过来
        /// </summary>
        public Int32 IsEnable
        {
            set{ _isenable=value;}
            get{return _isenable;}
        }
        /// <summary>
        /// 排序值，PMS传过来
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
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
