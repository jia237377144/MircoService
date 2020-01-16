/******************************************
* 模块名称：实体 模特信息配置多语言表
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
	/// 实体 模特信息配置多语言表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_mote_infokey_culturepart
	{
        #region 构造函数
        /// <summary>
        /// 实体 模特信息配置多语言表
        /// </summary>
        public product_mote_infokey_culturepart(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _moteinfokeyid = Int32.MinValue;
        private string _text = null;
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
        /// 多语言ID，对应网站已启用语言
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 模特属性键ID，PMS传过来
        /// </summary>
        public Int32 MoteInfoKeyID
        {
            set{ _moteinfokeyid=value;}
            get{return _moteinfokeyid;}
        }
        /// <summary>
        /// 模特属性值，多语言 PMS传过来
        /// </summary>
        public string Text
        {
            set{ _text=value;}
            get{return _text;}
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
