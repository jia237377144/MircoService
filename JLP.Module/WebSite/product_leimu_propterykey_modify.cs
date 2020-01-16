/******************************************
* 模块名称：实体 网站类目下的属性键修改名称，支持自定义显示
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
	/// 实体 网站类目下的属性键修改名称，支持自定义显示
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_leimu_propterykey_modify
	{
        #region 构造函数
        /// <summary>
        /// 实体 网站类目下的属性键修改名称，支持自定义显示
        /// </summary>
        public product_leimu_propterykey_modify(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _propertykey_culturepartid = Int32.MinValue;
        private string _text = null;
        private Int32 _status = Int32.MinValue;
        private string _remark = null;
        private Int32 _sort = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 属性键——多语言部分表的主键，（外键）,自己这边自增的ID
        /// </summary>
        public Int32 PropertyKey_CulturePartID
        {
            set{ _propertykey_culturepartid=value;}
            get{return _propertykey_culturepartid;}
        }
        /// <summary>
        /// 运营修改后的显示自定义属性键名称
        /// </summary>
        public string Text
        {
            set{ _text=value;}
            get{return _text;}
        }
        /// <summary>
        /// 枚举，显示，不显示
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set{ _remark=value;}
            get{return _remark;}
        }
        /// <summary>
        /// 备注
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
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
