/******************************************
* 模块名称：实体 品牌表
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
	/// 实体 品牌表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_brand
	{
        #region 构造函数
        /// <summary>
        /// 实体 品牌表
        /// </summary>
        public product_brand(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _name = null;
        private string _nameshort = null;
        private string _namecn = null;
        private string _logo = null;
        private string _founder = null;
        private string _founddate = null;
        private string _country = null;
        private string _officialwebsite = null;
        private Int32 _imitationlevel = Int32.MinValue;
        private string _categoryids = null;
        private string _remark = null;
        private Int32 _isenable = Int32.MinValue;
        private string _images = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        private Int32 _status = Int32.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键ID，PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 品牌全称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 品牌简称
        /// </summary>
        public string NameShort
        {
            set{ _nameshort=value;}
            get{return _nameshort;}
        }
        /// <summary>
        /// 品牌中文
        /// </summary>
        public string NameCn
        {
            set{ _namecn=value;}
            get{return _namecn;}
        }
        /// <summary>
        /// Logo
        /// </summary>
        public string Logo
        {
            set{ _logo=value;}
            get{return _logo;}
        }
        /// <summary>
        /// 创始人
        /// </summary>
        public string Founder
        {
            set{ _founder=value;}
            get{return _founder;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string FoundDate
        {
            set{ _founddate=value;}
            get{return _founddate;}
        }
        /// <summary>
        /// 所属国家
        /// </summary>
        public string Country
        {
            set{ _country=value;}
            get{return _country;}
        }
        /// <summary>
        /// 官网
        /// </summary>
        public string OfficialWebsite
        {
            set{ _officialwebsite=value;}
            get{return _officialwebsite;}
        }
        /// <summary>
        /// 仿货级别
        /// </summary>
        public Int32 ImitationLevel
        {
            set{ _imitationlevel=value;}
            get{return _imitationlevel;}
        }
        /// <summary>
        /// 可用品类
        /// </summary>
        public string CategoryIDs
        {
            set{ _categoryids=value;}
            get{return _categoryids;}
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
        /// 是否启用
        /// </summary>
        public Int32 IsEnable
        {
            set{ _isenable=value;}
            get{return _isenable;}
        }
        /// <summary>
        /// 图片
        /// </summary>
        public string Images
        {
            set{ _images=value;}
            get{return _images;}
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
        /// <summary>
        /// 网站端的状态，PMS没有这个字段
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        #endregion
	}
}
