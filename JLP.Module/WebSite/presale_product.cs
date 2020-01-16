/******************************************
* 模块名称：实体 预售产品表
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
	/// 实体 预售产品表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class presale_product
	{
        #region 构造函数
        /// <summary>
        /// 实体 预售产品表
        /// </summary>
        public presale_product(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _presaleinfoid = Int32.MinValue;
        private string _imagesrc = null;
        private Int32 _preferentialtype = Int32.MinValue;
        private Int32 _basenumber = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _abandonreason = null;
        private string _remark = null;
        private Int32 _sort = Int32.MinValue;
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
        /// presale_info表的主键ID，外键ID
        /// </summary>
        public Int32 PreSaleInfoID
        {
            set{ _presaleinfoid=value;}
            get{return _presaleinfoid;}
        }
        /// <summary>
        /// varchar
        /// </summary>
        public string ImageSrc
        {
            set{ _imagesrc=value;}
            get{return _imagesrc;}
        }
        /// <summary>
        /// 优惠模式 EProduct_PriceDaily_Special_Preferential_Type
        /// </summary>
        public Int32 PreferentialType
        {
            set{ _preferentialtype=value;}
            get{return _preferentialtype;}
        }
        /// <summary>
        /// 基数 只有区间预售和集赞预售有基数，相当于走后门
        /// </summary>
        public Int32 BaseNumber
        {
            set{ _basenumber=value;}
            get{return _basenumber;}
        }
        /// <summary>
        /// 通用的状态枚举 EStatus
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 放弃理由
        /// </summary>
        public string AbandonReason
        {
            set{ _abandonreason=value;}
            get{return _abandonreason;}
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
        /// 产品排序
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
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
