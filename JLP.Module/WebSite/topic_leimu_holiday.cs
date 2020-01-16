/******************************************
* 模块名称：实体 节日类目
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
	/// 实体 节日类目
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_leimu_holiday
	{
        #region 构造函数
        /// <summary>
        /// 实体 节日类目
        /// </summary>
        public topic_leimu_holiday(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private string _rule = null;
        private string _url = null;
        private Int32 _status = Int32.MinValue;
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
        /// 节日类目显示规则
        /// </summary>
        public string Rule
        {
            set{ _rule=value;}
            get{return _rule;}
        }
        /// <summary>
        /// 类目链接URL，有可能在专题的时候修改单独设置一个URL
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
