/******************************************
* 模块名称：实体 专题广告信息多语言
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
	/// 实体 专题广告信息多语言
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_ad_info_culture
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题广告信息多语言
        /// </summary>
        public topic_ad_info_culture(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _src = null;
        private Int32 _height = Int32.MinValue;
        private Int32 _width = Int32.MinValue;
        private string _text = null;
        private string _title = null;
        private string _href = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 广告信息ID，外键
        /// </summary>
        public Int32 InfoID
        {
            set{ _infoid=value;}
            get{return _infoid;}
        }
        /// <summary>
        /// 语言ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
        }
        /// <summary>
        /// 图片URL（仅在广告类型枚举-图片的时候使用）
        /// </summary>
        public string Src
        {
            set{ _src=value;}
            get{return _src;}
        }
        /// <summary>
        /// 图片高度
        /// </summary>
        public Int32 Height
        {
            set{ _height=value;}
            get{return _height;}
        }
        /// <summary>
        /// 图片宽度
        /// </summary>
        public Int32 Width
        {
            set{ _width=value;}
            get{return _width;}
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
        /// 鼠标放上去之后，图片或者文字显示的提示语
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 打开图片或文字对应的链接地址
        /// </summary>
        public string Href
        {
            set{ _href=value;}
            get{return _href;}
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
