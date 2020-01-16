/******************************************
* 模块名称：实体 VIEW
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
	/// 实体 VIEW
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class view_product_leimu_requiredkey
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_leimu_requiredkey(){}
        #endregion

        #region 私有变量
        private Int32 _spuid = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _requiredkeyid = Int32.MinValue;
        private string _name = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _isenable = Int32.MinValue;
        private Int32 _isused = Int32.MinValue;
        private Int32 _requiredkey_culturepartid = Int32.MinValue;
        private string _leimuname = null;
        private string _requiredkey_culturename = null;
        private Int32 _ispricerange = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// SPU ID(外键)
        /// </summary>
        public Int32 SpuId
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 类目ID(外键)
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 必选区键ID
        /// </summary>
        public Int32 RequiredKeyID
        {
            set{ _requiredkeyid=value;}
            get{return _requiredkeyid;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
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
        /// 语言ID (外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
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
        /// IsUsed
        /// </summary>
        public Int32 IsUsed
        {
            set{ _isused=value;}
            get{return _isused;}
        }
        /// <summary>
        /// 自增ID(NOT NULL)
        /// </summary>
        public Int32 RequiredKey_CulturePartID
        {
            set{ _requiredkey_culturepartid=value;}
            get{return _requiredkey_culturepartid;}
        }
        /// <summary>
        /// 中文名称
        /// </summary>
        public string LeiMuName
        {
            set{ _leimuname=value;}
            get{return _leimuname;}
        }
        /// <summary>
        /// 必选区KEY名称的显示文本
        /// </summary>
        public string RequiredKey_CultureName
        {
            set{ _requiredkey_culturename=value;}
            get{return _requiredkey_culturename;}
        }
        /// <summary>
        /// IsPriceRange
        /// </summary>
        public Int32 IsPriceRange
        {
            set{ _ispricerange=value;}
            get{return _ispricerange;}
        }
        #endregion
	}
}
