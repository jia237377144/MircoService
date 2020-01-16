/******************************************
* 模块名称：实体 图片表
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
	/// 实体 图片表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_image
	{
        #region 构造函数
        /// <summary>
        /// 实体 图片表
        /// </summary>
        public product_image(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _src = null;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private string _md5 = null;
        private Int32 _width = Int32.MinValue;
        private Int32 _height = Int32.MinValue;
        private Int32 _sort = Int32.MinValue;
        private Int32 _toserver = Int32.MinValue;
        private Int32 _isdelete = Int32.MinValue;
        private string _colorfeature = null;
        private string _contentfeature = null;
        private string _imagetypejson = null;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 PMS传过来的ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 路径
        /// </summary>
        public string Src
        {
            set{ _src=value;}
            get{return _src;}
        }
        /// <summary>
        /// SPUID(外键)
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// SKUID(外键)
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 文件的MD5
        /// </summary>
        public string MD5
        {
            set{ _md5=value;}
            get{return _md5;}
        }
        /// <summary>
        /// 宽度
        /// </summary>
        public Int32 Width
        {
            set{ _width=value;}
            get{return _width;}
        }
        /// <summary>
        /// 高度
        /// </summary>
        public Int32 Height
        {
            set{ _height=value;}
            get{return _height;}
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
        /// 是否保存到了图片服务器
        /// </summary>
        public Int32 ToServer
        {
            set{ _toserver=value;}
            get{return _toserver;}
        }
        /// <summary>
        /// 删除标记
        /// </summary>
        public Int32 IsDelete
        {
            set{ _isdelete=value;}
            get{return _isdelete;}
        }
        /// <summary>
        /// 颜色特征
        /// </summary>
        public string ColorFeature
        {
            set{ _colorfeature=value;}
            get{return _colorfeature;}
        }
        /// <summary>
        /// 内容特征
        /// </summary>
        public string ContentFeature
        {
            set{ _contentfeature=value;}
            get{return _contentfeature;}
        }
        /// <summary>
        /// ImageTypeJSON
        /// </summary>
        public string ImageTypeJSON
        {
            set{ _imagetypejson=value;}
            get{return _imagetypejson;}
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
