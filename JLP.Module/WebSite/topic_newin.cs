/******************************************
* 模块名称：实体 NewIn表 NewIn功能涉及到两个表 topic_newin 和 topic_newin_product
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
	/// 实体 NewIn表 NewIn功能涉及到两个表 topic_newin 和 topic_newin_product
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_newin
	{
        #region 构造函数
        /// <summary>
        /// 实体 NewIn表 NewIn功能涉及到两个表 topic_newin 和 topic_newin_product
        /// </summary>
        public topic_newin(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private Int32 _topicid = Int32.MinValue;
        private Int32 _newinurlflag = Int32.MinValue;
        private Int32 _scopetype = Int32.MinValue;
        private string _leimuidjson = null;
        private string _categoryidjson = null;
        private string _url = null;
        private Int32 _state = Int32.MinValue;
        private string _remark = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _showstyle = Int32.MinValue;
        private Int32 _lowestsellcount = Int32.MinValue;
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
        /// 名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
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
        /// NewIn页面URL数字标识
        /// </summary>
        public Int32 NewInUrlFlag
        {
            set{ _newinurlflag=value;}
            get{return _newinurlflag;}
        }
        /// <summary>
        /// 作用类型 类目还是品类 对应程序里的枚举 EActive_List_ScopeLeiMuOrPinLei
        /// </summary>
        public Int32 ScopeType
        {
            set{ _scopetype=value;}
            get{return _scopetype;}
        }
        /// <summary>
        /// 可配置的多个类目 例如[456875,452669] 
        /// </summary>
        public string LeiMuIDJSON
        {
            set{ _leimuidjson=value;}
            get{return _leimuidjson;}
        }
        /// <summary>
        /// 可配置的多个品类 例如[456875,452669] 
        /// </summary>
        public string CategoryIDJSON
        {
            set{ _categoryidjson=value;}
            get{return _categoryidjson;}
        }
        /// <summary>
        /// newin页面的url 预留字段 
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
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
        /// 备注
        /// </summary>
        public string Remark
        {
            set{ _remark=value;}
            get{return _remark;}
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
        /// ShowStyle
        /// </summary>
        public Int32 ShowStyle
        {
            set{ _showstyle=value;}
            get{return _showstyle;}
        }
        /// <summary>
        /// LowestSellCount
        /// </summary>
        public Int32 LowestSellCount
        {
            set{ _lowestsellcount=value;}
            get{return _lowestsellcount;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
