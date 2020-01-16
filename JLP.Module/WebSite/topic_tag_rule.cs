/******************************************
* 模块名称：实体 专题Tag词规则信息
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
	/// 实体 专题Tag词规则信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_tag_rule
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题Tag词规则信息
        /// </summary>
        public topic_tag_rule(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _moduleid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private string _tagtitle = null;
        private Int32 _tagtype = Int32.MinValue;
        private string _tagkeywords = null;
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
        /// 主键 主键，自增ID(NOT NULL)
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
        /// Tag标题
        /// </summary>
        public string TagTitle
        {
            set{ _tagtitle=value;}
            get{return _tagtitle;}
        }
        /// <summary>
        /// Tag词枚举类型（1:节日Tag词 2:最新上传节日Tag词 3:最新上传类目Tag词）
        /// </summary>
        public Int32 TagType
        {
            set{ _tagtype=value;}
            get{return _tagtype;}
        }
        /// <summary>
        /// Tag搜索关键词
        /// </summary>
        public string TagKeywords
        {
            set{ _tagkeywords=value;}
            get{return _tagkeywords;}
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
        /// 最后一个编辑人的修改内容
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
