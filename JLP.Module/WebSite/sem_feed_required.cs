/******************************************
* 模块名称：实体 Feed必选区
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
	/// 实体 Feed必选区
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class sem_feed_required
	{
        #region 构造函数
        /// <summary>
        /// 实体 Feed必选区
        /// </summary>
        public sem_feed_required(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private string _image = null;
        private string _images = null;
        private string _imagesoffeed = null;
        private Int32 _colorrequiredkeyid = Int32.MinValue;
        private Int32 _colorrequiredvalueid = Int32.MinValue;
        private Int32 _sizerequiredkeyid = Int32.MinValue;
        private Int32 _sizerequiredvalueid = Int32.MinValue;
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
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
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
        /// 产品图片
        /// </summary>
        public string Image
        {
            set{ _image=value;}
            get{return _image;}
        }
        /// <summary>
        /// SKU附图
        /// </summary>
        public string Images
        {
            set{ _images=value;}
            get{return _images;}
        }
        /// <summary>
        /// Feed广告图集数组
        /// </summary>
        public string ImagesOfFeed
        {
            set{ _imagesoffeed=value;}
            get{return _imagesoffeed;}
        }
        /// <summary>
        /// 颜色必选区键ID
        /// </summary>
        public Int32 ColorRequiredKeyID
        {
            set{ _colorrequiredkeyid=value;}
            get{return _colorrequiredkeyid;}
        }
        /// <summary>
        /// 颜色必选区值ID
        /// </summary>
        public Int32 ColorRequiredValueID
        {
            set{ _colorrequiredvalueid=value;}
            get{return _colorrequiredvalueid;}
        }
        /// <summary>
        /// 尺寸必选区键ID
        /// </summary>
        public Int32 SizeRequiredKeyID
        {
            set{ _sizerequiredkeyid=value;}
            get{return _sizerequiredkeyid;}
        }
        /// <summary>
        /// 尺寸必选区值ID
        /// </summary>
        public Int32 SizeRequiredValueID
        {
            set{ _sizerequiredvalueid=value;}
            get{return _sizerequiredvalueid;}
        }
        #endregion
	}
}
