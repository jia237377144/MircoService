/******************************************
* 模块名称：实体 产品附加的图标
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
	/// 实体 产品附加的图标
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_icon
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品附加的图标
        /// </summary>
        public product_icon(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _icontype = Int32.MinValue;
        private Int32 _showtype = Int32.MinValue;
        private string _name = null;
        private string _iconsrc = null;
        private Int32 _status = Int32.MinValue;
        private string _platformjson = null;
        private string _spuidjson = null;
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
        /// 图标类型，枚举类型
        /// </summary>
        public Int32 IconType
        {
            set{ _icontype=value;}
            get{return _icontype;}
        }
        /// <summary>
        /// 显示类型
        /// </summary>
        public Int32 ShowType
        {
            set{ _showtype=value;}
            get{return _showtype;}
        }
        /// <summary>
        /// 图标名称(中文名称)
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 图标路径(绝对路径)
        /// </summary>
        public string IconSrc
        {
            set{ _iconsrc=value;}
            get{return _iconsrc;}
        }
        /// <summary>
        /// 图标状态，枚举类型
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 枚举:类目显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 自定义图标SPUID JSON
        /// </summary>
        public string SPUIDJSON
        {
            set{ _spuidjson=value;}
            get{return _spuidjson;}
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
