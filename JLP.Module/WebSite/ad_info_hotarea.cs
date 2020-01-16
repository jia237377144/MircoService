/******************************************
* 模块名称：实体 广告图片热区
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
	/// 实体 广告图片热区
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class ad_info_hotarea
	{
        #region 构造函数
        /// <summary>
        /// 实体 广告图片热区
        /// </summary>
        public ad_info_hotarea(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infocultureid = Int32.MinValue;
        private string _title = null;
        private string _href = null;
        private Int32 _shape = Int32.MinValue;
        private string _coords = null;
        private Int32 _state = Int32.MinValue;
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
        /// 广告信息多语言ID，外键
        /// </summary>
        public Int32 InfoCultureID
        {
            set{ _infocultureid=value;}
            get{return _infocultureid;}
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
        /// 点击图片热区对应的链接地址
        /// </summary>
        public string Href
        {
            set{ _href=value;}
            get{return _href;}
        }
        /// <summary>
        /// 图片热区类型枚举（Rect=1,Circle=2,Poligon=3）
        /// </summary>
        public Int32 Shape
        {
            set{ _shape=value;}
            get{return _shape;}
        }
        /// <summary>
        /// 图片热区坐标
        /// </summary>
        public string Coords
        {
            set{ _coords=value;}
            get{return _coords;}
        }
        /// <summary>
        /// 图片热区状态（有效=1，无效=0）
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
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
