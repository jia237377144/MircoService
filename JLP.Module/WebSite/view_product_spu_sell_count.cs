/******************************************
* 模块名称：实体 VIEW
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
	/// 实体 VIEW
	/// </summary>
	[Description("Primary:")]
    [Serializable]
	public class view_product_spu_sell_count
	{
        #region 构造函数
        /// <summary>
        /// 实体 VIEW
        /// </summary>
        public view_product_spu_sell_count(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _realcount = Int32.MinValue;
        private Int32 _manualcount = Int32.MinValue;
        private DateTime _intotime = DateTime.MinValue;
        private Int32 _spustatus = Int32.MinValue;
        private Int32 _spurender = Int32.MinValue;
        private string _platformjson = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键,自增ID(NOT NULL)
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
        /// <summary>
        /// SPU状态枚举（待编辑=0、下架=1、上架=2、定时上架=3）
        /// </summary>
        public Int32 SpuStatus
        {
            set{ _spustatus=value;}
            get{return _spustatus;}
        }
        /// <summary>
        /// SPU显示状态(显示=1，隐藏=0)
        /// </summary>
        public Int32 SpuRender
        {
            set{ _spurender=value;}
            get{return _spurender;}
        }
        /// <summary>
        /// 枚举：SPU显示平台JSON
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        #endregion
	}
}
