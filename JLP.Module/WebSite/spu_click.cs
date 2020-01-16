/******************************************
* 模块名称：实体 产品的点击次数
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
	/// 实体 产品的点击次数
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class spu_click
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品的点击次数
        /// </summary>
        public spu_click(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _realclickcount = Int32.MinValue;
        private Int32 _manualclickcount = Int32.MinValue;
        private DateTime _intodate = DateTime.MinValue;
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
        /// 产品页URL中的ID
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
        /// 真实的SPU点击数量
        /// </summary>
        public Int32 RealClickCount
        {
            set{ _realclickcount=value;}
            get{return _realclickcount;}
        }
        /// <summary>
        /// 人工干预的SPU点击数量
        /// </summary>
        public Int32 ManualClickCount
        {
            set{ _manualclickcount=value;}
            get{return _manualclickcount;}
        }
        /// <summary>
        /// SPU点击日期
        /// </summary>
        public DateTime InToDate
        {
            set{ _intodate=value;}
            get{return _intodate;}
        }
        #endregion
	}
}
