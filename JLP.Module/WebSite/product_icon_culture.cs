﻿/******************************************
* 模块名称：实体 产品附加图标多语言信息
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
	/// 实体 产品附加图标多语言信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_icon_culture
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品附加图标多语言信息
        /// </summary>
        public product_icon_culture(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _iconid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _tip = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 附加图标ID，外键ID
        /// </summary>
        public Int32 IconID
        {
            set{ _iconid=value;}
            get{return _iconid;}
        }
        /// <summary>
        /// 附加图标提示信息多语言ID，外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 附加图标提示信息（alt和title属性值）
        /// </summary>
        public string Tip
        {
            set{ _tip=value;}
            get{return _tip;}
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
