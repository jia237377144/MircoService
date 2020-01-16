/******************************************
* 模块名称：实体 产品销量表
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
	/// 实体 产品销量表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_sell_count
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品销量表
        /// </summary>
        public product_sell_count(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _realcount = Int32.MinValue;
        private Int32 _manualcount = Int32.MinValue;
        private DateTime _intotime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 主键,自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 产品ProductID,URL的产品ID
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
        /// 真实的SPU销售数量
        /// </summary>
        public Int32 RealCount
        {
            set{ _realcount=value;}
            get{return _realcount;}
        }
        /// <summary>
        /// 人工干预的SPU销售数量
        /// </summary>
        public Int32 ManualCount
        {
            set{ _manualcount=value;}
            get{return _manualcount;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime InToTime
        {
            set{ _intotime=value;}
            get{return _intotime;}
        }
        #endregion
	}
}
