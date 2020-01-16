/******************************************
* 模块名称：实体 节日类目页表
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
	/// 实体 节日类目页表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_holiday_leimu
	{
        #region 构造函数
        /// <summary>
        /// 实体 节日类目页表
        /// </summary>
        public topic_holiday_leimu(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topicid = Int32.MinValue;
        private string _leimuidjson = null;
        private Int32 _state = Int32.MinValue;
        private Int32 _totalcount = Int32.MinValue;
        private Int32 _takecount = Int32.MinValue;
        private Int32 _sorttype = Int32.MinValue;
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
        /// topic_holiday表的主键ID
        /// </summary>
        public Int32 TopicID
        {
            set{ _topicid=value;}
            get{return _topicid;}
        }
        /// <summary>
        /// 类目ID
        /// </summary>
        public string LeiMuIDJSON
        {
            set{ _leimuidjson=value;}
            get{return _leimuidjson;}
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
        /// 从总数TotalCount随机取TakeCount个数量
        /// </summary>
        public Int32 TotalCount
        {
            set{ _totalcount=value;}
            get{return _totalcount;}
        }
        /// <summary>
        /// 取的产品数量（该专题下每个类目对应的节日类目页取多少个产品）
        /// </summary>
        public Int32 TakeCount
        {
            set{ _takecount=value;}
            get{return _takecount;}
        }
        /// <summary>
        /// 节日类目页产品的排序规则枚举类型：1：浏览量，2：销量，3：上架时间
        /// </summary>
        public Int32 SortType
        {
            set{ _sorttype=value;}
            get{return _sorttype;}
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
