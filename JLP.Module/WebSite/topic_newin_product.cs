/******************************************
* 模块名称：实体 NewIn 手动添加的产品
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
	/// 实体 NewIn 手动添加的产品
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_newin_product
	{
        #region 构造函数
        /// <summary>
        /// 实体 NewIn 手动添加的产品
        /// </summary>
        public topic_newin_product(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _newinid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private string _title = null;
        private string _url = null;
        private string _imagesrc = null;
        private Int32 _state = Int32.MinValue;
        private string _remark = null;
        private Int32 _sort = Int32.MinValue;
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
        /// NewInID  这个产品是增加到那个NewIn下
        /// </summary>
        public Int32 NewInID
        {
            set{ _newinid=value;}
            get{return _newinid;}
        }
        /// <summary>
        /// PID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Title
        {
            set{ _title=value;}
            get{return _title;}
        }
        /// <summary>
        /// 产品地址 保留字段
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 产品图片
        /// </summary>
        public string ImageSrc
        {
            set{ _imagesrc=value;}
            get{return _imagesrc;}
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
