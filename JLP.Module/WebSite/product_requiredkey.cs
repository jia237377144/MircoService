/******************************************
* 模块名称：实体 产品必选区键
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
	/// 实体 产品必选区键
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_requiredkey
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品必选区键
        /// </summary>
        public product_requiredkey(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _categoryid = Int32.MinValue;
        private string _name = null;
        private Int32 _displaytype = Int32.MinValue;
        private Int32 _isenable = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _isdisplayoncustomize = Int32.MinValue;
        private Int32 _isdisplayongeneral = Int32.MinValue;
        private Int32 _isused = Int32.MinValue;
        private Int32 _isapplyallvalue = Int32.MinValue;
        private Int32 _isrequired = Int32.MinValue;
        private Int32 _displaymode = Int32.MinValue;
        private string _remark = null;
        private string _relationkeyids = null;
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
        /// 必选区键
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 类型[枚举] ：单行文本、多行文本、下拉列表、多选、日期、日期时间、时间、图片、脚本
        /// </summary>
        public Int32 DisplayType
        {
            set{ _displaytype=value;}
            get{return _displaytype;}
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
        /// 排序
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 定制模式是否显示
        /// </summary>
        public Int32 IsDisplayOnCustomize
        {
            set{ _isdisplayoncustomize=value;}
            get{return _isdisplayoncustomize;}
        }
        /// <summary>
        /// 普通模式是否显示
        /// </summary>
        public Int32 IsDisplayOnGeneral
        {
            set{ _isdisplayongeneral=value;}
            get{return _isdisplayongeneral;}
        }
        /// <summary>
        /// IsUsed
        /// </summary>
        public Int32 IsUsed
        {
            set{ _isused=value;}
            get{return _isused;}
        }
        /// <summary>
        /// 是否应用所有值枚举（是=1，否=0），只会出现在在定制项（IsDisplayOnCustomize=true）。
        /// </summary>
        public Int32 IsApplyAllValue
        {
            set{ _isapplyallvalue=value;}
            get{return _isapplyallvalue;}
        }
        /// <summary>
        /// 是否为必填项枚举（必填=1，非必填=0），如果IsApplyAllValue=true，本列必须设置为非必填。
        /// </summary>
        public Int32 IsRequired
        {
            set{ _isrequired=value;}
            get{return _isrequired;}
        }
        /// <summary>
        /// 显示模式[枚举]：0=文本，1=图片，2=文本&图片
        /// </summary>
        public Int32 DisplayMode
        {
            set{ _displaymode=value;}
            get{return _displaymode;}
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
        /// 关联Keys。如:颜色，颜色-定制项应当设置在颜色上加上。可以理解为在生成的sku的键上加。格式：ID0,ID1,ID2 .用途：用于前台web合并必选用
        /// </summary>
        public string RelationKeyIDs
        {
            set{ _relationkeyids=value;}
            get{return _relationkeyids;}
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
