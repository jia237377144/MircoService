/******************************************
* 模块名称：实体 专题标签表
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
	/// 实体 专题标签表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_label
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题标签表
        /// </summary>
        public topic_label(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _moduleid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private string _title = null;
        private string _platformjson = null;
        private string _url = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private string _lastupdatecontent = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID，自增ID(NOT NULL)
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
        /// 广告位ID，枚举类型ID
        /// </summary>
        public Int32 PositionID
        {
            set{ _positionid=value;}
            get{return _positionid;}
        }
        /// <summary>
        /// 标签标题
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 适用平台
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 标签跳转地址
        /// </summary>
        public string Url
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
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
        /// 最后一次修改内容
        /// </summary>
        public string LastUpdateContent
        {
            set{ _lastupdatecontent=value;}
            get{return _lastupdatecontent;}
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
