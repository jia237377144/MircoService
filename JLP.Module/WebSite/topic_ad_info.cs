/******************************************
* 模块名称：实体 专题广告信息
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
	/// 实体 专题广告信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_ad_info
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题广告信息
        /// </summary>
        public topic_ad_info(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _moduleid = Int32.MinValue;
        private Int32 _templateid = Int32.MinValue;
        private Int32 _adtype = Int32.MinValue;
        private string _name = null;
        private Int32 _labelid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private string _platformjson = null;
        private string _usertypejson = null;
        private Int32 _iscountdown = Int32.MinValue;
        private string _trackcode = null;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _state = Int32.MinValue;
        private string _lastupdatecontent = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键、自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 专题信息ID，外键ID
        /// </summary>
        public Int32 InfoID
        {
            set{ _infoid=value;}
            get{return _infoid;}
        }
        /// <summary>
        /// 模块ID，关联一个模块内的标签、产品、图片等
        /// </summary>
        public Int32 ModuleID
        {
            set{ _moduleid=value;}
            get{return _moduleid;}
        }
        /// <summary>
        /// 模板ID，外键ID
        /// </summary>
        public Int32 TemplateID
        {
            set{ _templateid=value;}
            get{return _templateid;}
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
        /// 产品信息标签ID
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
        /// 广告使用平台枚举：PC，M，APP
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 广告用户类型：登录用户，未登录用户
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
        /// 最后一个编辑人的修改内容
        /// </summary>
        public string LastUpdateContent
        {
            set{ _lastupdatecontent=value;}
            get{return _lastupdatecontent;}
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
