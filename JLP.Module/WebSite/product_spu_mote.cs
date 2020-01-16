/******************************************
* 模块名称：实体 SPU模特表
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
	/// 实体 SPU模特表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_mote
	{
        #region 构造函数
        /// <summary>
        /// 实体 SPU模特表
        /// </summary>
        public product_spu_mote(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _moteid = Int32.MinValue;
        private string _name = null;
        private DateTime _birthday = DateTime.MinValue;
        private string _sex = null;
        private string _infosjson = null;
        private string _image = null;
        private string _requiredvalue = null;
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
        /// SPUID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 模特ID,由PMS传过来
        /// </summary>
        public Int32 MoteID
        {
            set{ _moteid=value;}
            get{return _moteid;}
        }
        /// <summary>
        /// 模特名字,由PMS传过来
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 模特生日
        /// </summary>
        public DateTime Birthday
        {
            set{ _birthday=value;}
            get{return _birthday;}
        }
        /// <summary>
        /// 性别【 F/M 】
        /// </summary>
        public string Sex
        {
            set{ _sex=value;}
            get{return _sex;}
        }
        /// <summary>
        /// 模特试穿具体信息JSON
        /// </summary>
        public string InfosJSON
        {
            set{ _infosjson=value;}
            get{return _infosjson;}
        }
        /// <summary>
        /// 模特图片地址
        /// </summary>
        public string Image
        {
            set{ _image=value;}
            get{return _image;}
        }
        /// <summary>
        /// 模特试穿尺寸【S,L,M】
        /// </summary>
        public string RequiredValue
        {
            set{ _requiredvalue=value;}
            get{return _requiredvalue;}
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
