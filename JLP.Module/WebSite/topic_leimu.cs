/******************************************
* 模块名称：实体 专题推荐类目
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
	/// 实体 专题推荐类目
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_leimu
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题推荐类目
        /// </summary>
        public topic_leimu(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private string _name = null;
        private Int32 _leimuid = Int32.MinValue;
        private Int32 _ruletype = Int32.MinValue;
        private string _url = null;
        private Int32 _status = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _isholidayshow = Int32.MinValue;
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
        /// 广告位ID，枚举类型ID
        /// </summary>
        public Int32 PositionID
        {
            set{ _positionid=value;}
            get{return _positionid;}
        }
        /// <summary>
        /// 类目自定义名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 类目ID，外键ID，专题推荐类目表的ID
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 规则类型(1:推荐、2:新品、3:销量、4:自定义)
        /// </summary>
        public Int32 RuleType
        {
            set{ _ruletype=value;}
            get{return _ruletype;}
        }
        /// <summary>
        /// 类目链接URL
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
        /// 排序编号
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 推荐类目是否按节日类目显示(1:显示,2:不显示)
        /// </summary>
        public Int32 IsHolidayShow
        {
            set{ _isholidayshow=value;}
            get{return _isholidayshow;}
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
