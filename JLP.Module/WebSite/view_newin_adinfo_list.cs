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
	public class view_newin_adinfo_list
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_newin_adinfo_list(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _newinid = Int32.MinValue;
        private Int32 _adinfoid = Int32.MinValue;
        private string _newinname = null;
        private Int32 _topicid = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private string _adname = null;
        private string _src = null;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private Int32 _labelid = Int32.MinValue;
        private Int32 _adtype = Int32.MinValue;
        private Int32 _pagetype = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private string _platformjson = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键ID，自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// topic_newin表的主键ID，外键ID
        /// </summary>
        public Int32 NewInID
        {
            set{ _newinid=value;}
            get{return _newinid;}
        }
        /// <summary>
        /// ad_info表的主键ID，外键ID
        /// </summary>
        public Int32 AdInfoID
        {
            set{ _adinfoid=value;}
            get{return _adinfoid;}
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string NewInName
        {
            set{ _newinname=value;}
            get{return _newinname;}
        }
        /// <summary>
        /// TopicID  这块内容属于哪个专题 NewInPC or NewInM or NewInAPP 
        /// </summary>
        public Int32 TopicID
        {
            set{ _topicid=value;}
            get{return _topicid;}
        }
        /// <summary>
        /// 状态 0：停用      1：启用  和程序里的EStatus对应
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// 广告信息名称
        /// </summary>
        public string AdName
        {
            set{ _adname=value;}
            get{return _adname;}
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
        /// 广告信息标签ID
        /// </summary>
        public Int32 LabelID
        {
            set{ _labelid=value;}
            get{return _labelid;}
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
        /// 广告页面分类枚举(首页、列表、终端、广告）
        /// </summary>
        public Int32 PageType
        {
            set{ _pagetype=value;}
            get{return _pagetype;}
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
        /// 广告使用平台枚举：PC，M，APP
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        #endregion
	}
}
