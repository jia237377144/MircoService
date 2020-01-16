/******************************************
* 模块名称：实体 节日专题表
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
	/// 实体 节日专题表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_holiday
	{
        #region 构造函数
        /// <summary>
        /// 实体 节日专题表
        /// </summary>
        public topic_holiday(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topickey = Int32.MinValue;
        private Int32 _topicurlflag = Int32.MinValue;
        private string _entryimagesrc = null;
        private string _bannerimagesrc = null;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private Int32 _state = Int32.MinValue;
        private string _url = null;
        private string _topicleimujson = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 关联的专题ID 手动录入的
        /// </summary>
        public Int32 TopicKey
        {
            set{ _topickey=value;}
            get{return _topickey;}
        }
        /// <summary>
        /// 专题页面url里的数字标识 手动录入
        /// </summary>
        public Int32 TopicUrlFlag
        {
            set{ _topicurlflag=value;}
            get{return _topicurlflag;}
        }
        /// <summary>
        /// 聚合页节日专题入口的图片
        /// </summary>
        public string EntryImageSrc
        {
            set{ _entryimagesrc=value;}
            get{return _entryimagesrc;}
        }
        /// <summary>
        /// 节日专题详情页顶部banner图片地址
        /// </summary>
        public string BannerImageSrc
        {
            set{ _bannerimagesrc=value;}
            get{return _bannerimagesrc;}
        }
        /// <summary>
        /// 专题活动开始时间
        /// </summary>
        public DateTime StartTime
        {
            set{ _starttime=value;}
            get{return _starttime;}
        }
        /// <summary>
        /// 专题活动结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
        }
        /// <summary>
        /// 控制状态枚举：1：显示，0：隐藏
        /// </summary>
        public Int32 State
        {
            set{ _state=value;}
            get{return _state;}
        }
        /// <summary>
        /// URL地址（聚合页指向节日专题页的地址）
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 专题类目 直接构建好层级关系
        /// </summary>
        public string TopicLeiMuJSON
        {
            set{ _topicleimujson=value;}
            get{return _topicleimujson;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
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
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
