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
	public class view_product_leimu_propertykey
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_leimu_propertykey(){}
        #endregion

        #region 私有变量
        private Int32 _spuid = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _propertykeyid = Int32.MinValue;
        private string _name = null;
        private string _text = null;
        private Int32 _status = Int32.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
        private string _remark = null;
        private long _sort = long.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _propertykey_culturepartid = Int32.MinValue;
        private string _leimuname = null;
        private string _propertykey_culturename = null;
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
        /// 属性键ID(外键),自己这边自增的ID
        /// </summary>
        public Int32 PropertyKeyID
        {
            set{ _propertykeyid=value;}
            get{return _propertykeyid;}
        }
        /// <summary>
        /// KEY 的名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// Text
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
        /// 备注
        /// </summary>
        public string Remark
        {
            set{ _remark=value;}
            get{return _remark;}
        }
        /// <summary>
        /// Sort
        /// </summary>
        public long Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 语言ID(外键)
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 自增ID(NOT NULL)
        /// </summary>
        public Int32 PropertyKey_CulturePartID
        {
            set{ _propertykey_culturepartid=value;}
            get{return _propertykey_culturepartid;}
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
        /// 属性KEY 的显示文本
        /// </summary>
        public string PropertyKey_CultureName
        {
            set{ _propertykey_culturename=value;}
            get{return _propertykey_culturename;}
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
