/******************************************
* 模块名称：实体 模特信息表（未来取代product_mote表）
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
	/// 实体 模特信息表（未来取代product_mote表）
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_mote_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 模特信息表（未来取代product_mote表）
        /// </summary>
        public product_mote_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _moteid = Int32.MinValue;
        private Int32 _moteinfokeyid = Int32.MinValue;
        private decimal _value = decimal.MinValue;
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
        /// 模特ID，PMS传过来的ID
        /// </summary>
        public Int32 MoteID
        {
            set{ _moteid=value;}
            get{return _moteid;}
        }
        /// <summary>
        /// 模特属性键ID，PMS传过来的ID
        /// </summary>
        public Int32 MoteInfoKeyID
        {
            set{ _moteinfokeyid=value;}
            get{return _moteinfokeyid;}
        }
        /// <summary>
        /// 模特属性值，PMS传过来的
        /// </summary>
        public decimal Value
        {
            set{ _value=value;}
            get{return _value;}
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
