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
	public class view_ad_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_ad_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pageid = Int32.MinValue;
        private Int32 _adtype = Int32.MinValue;
        private string _name = null;
        private Int32 _labelid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _pagetype = Int32.MinValue;
        private Int32 _rendertype = Int32.MinValue;
        private string _platformjson = null;
        private string _usertypejson = null;
        private Int32 _iscountdown = Int32.MinValue;
        private string _trackcode = null;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private Int32 _adcultureid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private string _src = null;
        private string _title = null;
        private string _text = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键、自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 广告投放页面ID，外键
        /// </summary>
        public Int32 PageID
        {
            set{ _pageid=value;}
            get{return _pageid;}
        }
        /// <summary>
        /// 广告信息类型枚举（ 图片、文字）
        /// </summary>
        public Int32 ADType
        {
            set{ _adtype=value;}
            get{return _adtype;}
        }
        /// <summary>
        /// 广告信息名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 广告信息标签ID
        /// </summary>
        public Int32 LabelID
        {
            set{ _labelid=value;}
            get{return _labelid;}
        }
        /// <summary>
        /// 广告位ID（自定义编号）
        /// </summary>
        public Int32 PositionID
        {
            set{ _positionid=value;}
            get{return _positionid;}
        }
        /// <summary>
        /// 类目ID
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 广告页面分类枚举(首页、列表、终端、广告）
        /// </summary>
        public Int32 PageType
        {
            set{ _pagetype=value;}
            get{return _pagetype;}
        }
        /// <summary>
        /// 广告展示方式类型枚举（固定、幻灯片变换、根据刷新次数切换、根据类目ID切换，图文并茂）
        /// </summary>
        public Int32 RenderType
        {
            set{ _rendertype=value;}
            get{return _rendertype;}
        }
        /// <summary>
        /// 广告使用平台枚举：PC，M，APP
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 广告用户类型：登录用户,未登录用户
        /// </summary>
        public string UserTypeJSON
        {
            set{ _usertypejson=value;}
            get{return _usertypejson;}
        }
        /// <summary>
        /// 是否倒计时枚举（是=1，否=0）
        /// </summary>
        public Int32 IsCountDown
        {
            set{ _iscountdown=value;}
            get{return _iscountdown;}
        }
        /// <summary>
        /// 追踪代码，不为空就是有追踪代码
        /// </summary>
        public string TrackCode
        {
            set{ _trackcode=value;}
            get{return _trackcode;}
        }
        /// <summary>
        /// 广告开始时间
        /// </summary>
        public DateTime StartTime
        {
            set{ _starttime=value;}
            get{return _starttime;}
        }
        /// <summary>
        /// 广告结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
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
        /// 广告信息状态枚举（有效=1，无效=0）
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
        /// <summary>
        /// 主键，自增ID
        /// </summary>
        public Int32 AdCultureID
        {
            set{ _adcultureid=value;}
            get{return _adcultureid;}
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
        /// 鼠标放上去之后，图片或者文字显示的提示语
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 文字内容（广告类型枚举-文字的时候使用）
        /// </summary>
        public string Text
        {
            set{ _text=value;}
            get{return _text;}
        }
        #endregion
	}
}
