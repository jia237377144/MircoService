/******************************************
* 模块名称：实体 预售商品点赞统计表
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
	/// 实体 预售商品点赞统计表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class presale_product_praise_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 预售商品点赞统计表
        /// </summary>
        public presale_product_praise_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
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
        /// UserID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
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
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        #endregion
	}
}
