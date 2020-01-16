/******************************************
* 模块名称：实体 sem_feed_spu_image
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
	/// 实体 sem_feed_spu_image
	/// </summary>
	[Description("Primary:Id")]
    [Serializable]
	public class sem_feed_spu_image
	{
        #region 构造函数
        /// <summary>
        /// 实体 sem_feed_spu_image
        /// </summary>
        public sem_feed_spu_image(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _images = null;
        private DateTime _adddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 Id(NOT NULL)
        /// </summary>
        public Int32 Id
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SpuId
        /// </summary>
        public Int32 SpuId
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// Images
        /// </summary>
        public string Images
        {
            set{ _images=value;}
            get{return _images;}
        }
        /// <summary>
        /// AddDate
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        #endregion
	}
}
