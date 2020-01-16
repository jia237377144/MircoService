/******************************************
* 模块名称：实体 搭配销售组
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
	/// 实体 搭配销售组
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_combine_group
	{
        #region 构造函数
        /// <summary>
        /// 实体 搭配销售组
        /// </summary>
        public product_combine_group(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _collocationid = Int32.MinValue;
        private string _title = null;
        private string _imagesrc = null;
        private string _description = null;
        private string _forcespuidjson = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private Int32 _syncstatus = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// 产品库搭配销售ID
        /// </summary>
        public Int32 CollocationID
        {
            set{ _collocationid=value;}
            get{return _collocationid;}
        }
        /// <summary>
        /// 搭配标题
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 搭配主图
        /// </summary>
        public string ImageSrc
        {
            set{ _imagesrc=value;}
            get{return _imagesrc;}
        }
        /// <summary>
        /// 搭配描述
        /// </summary>
        public string Description
        {
            set{ _description=value;}
            get{return _description;}
        }
        /// <summary>
        /// 强制必须购买的SPUID
        /// </summary>
        public string ForceSPUIDJSON
        {
            set{ _forcespuidjson=value;}
            get{return _forcespuidjson;}
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
        /// 状态（-1待处理，0停用，1启用）
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// PMS搭配组合有效性（有效=1，无效=0）
        /// </summary>
        public Int32 SyncStatus
        {
            set{ _syncstatus=value;}
            get{return _syncstatus;}
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
