/******************************************
* 模块名称：实体 产品必选区值
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
	/// 实体 产品必选区值
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_requiredvalue
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品必选区值
        /// </summary>
        public product_requiredvalue(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private Int32 _requiredkeyid = Int32.MinValue;
        private string _value = null;
        private string _image = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _isenable = Int32.MinValue;
        private string _groups = null;
        private string _remark = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 品类ID,PMS传过来的ID
        /// </summary>
        public Int32 CategoryID
        {
            set{ _categoryid=value;}
            get{return _categoryid;}
        }
        /// <summary>
        /// 必选区键ID，外键
        /// </summary>
        public Int32 RequiredKeyID
        {
            set{ _requiredkeyid=value;}
            get{return _requiredkeyid;}
        }
        /// <summary>
        /// 必选区值
        /// </summary>
        public string Value
        {
            set{ _value=value;}
            get{return _value;}
        }
        /// <summary>
        /// 必选区图片Src
        /// </summary>
        public string Image
        {
            set{ _image=value;}
            get{return _image;}
        }
        /// <summary>
        /// 排序
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public Int32 IsEnable
        {
            set{ _isenable=value;}
            get{return _isenable;}
        }
        /// <summary>
        /// Groups
        /// </summary>
        public string Groups
        {
            set{ _groups=value;}
            get{return _groups;}
        }
        /// <summary>
        /// Remark
        /// </summary>
        public string Remark
        {
            set{ _remark=value;}
            get{return _remark;}
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
