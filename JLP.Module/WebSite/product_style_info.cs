/******************************************
* 模块名称：实体 产品风格表，用来存储风格属性值，与风格词关联
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
	/// 实体 产品风格表，用来存储风格属性值，与风格词关联
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_style_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品风格表，用来存储风格属性值，与风格词关联
        /// </summary>
        public product_style_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _stylewordid = Int32.MinValue;
        private Int32 _propertyvalueid = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
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
        /// 风格词ID，外键ID 
        /// </summary>
        public Int32 StyleWordID
        {
            set{ _stylewordid=value;}
            get{return _stylewordid;}
        }
        /// <summary>
        /// 风格属性值ID
        /// </summary>
        public Int32 PropertyValueID
        {
            set{ _propertyvalueid=value;}
            get{return _propertyvalueid;}
        }
        /// <summary>
        /// 品类ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 词状态EProduct_Style_Info_Status枚举类型（0禁用，1启用）
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
