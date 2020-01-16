/******************************************
* 模块名称：实体 选项卡标签表
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
	/// 实体 选项卡标签表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_tab_name
	{
        #region 构造函数
        /// <summary>
        /// 实体 选项卡标签表
        /// </summary>
        public product_tab_name(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private string _cnname = null;
        private string _enname = null;
        private string _imagelogo = null;
        private Int32 _status = Int32.MinValue;
        private string _note = null;
        private Int32 _platform = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// 中文名称
        /// </summary>
        public string CNName
        {
            set{ _cnname=value;}
            get{return _cnname;}
        }
        /// <summary>
        /// 英文名称
        /// </summary>
        public string ENName
        {
            set{ _enname=value;}
            get{return _enname;}
        }
        /// <summary>
        /// 选项卡标签Logo
        /// </summary>
        public string ImageLogo
        {
            set{ _imagelogo=value;}
            get{return _imagelogo;}
        }
        /// <summary>
        /// 状态（弃用，禁用）
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note
        {
            set{ _note=value;}
            get{return _note;}
        }
        /// <summary>
        /// Platform
        /// </summary>
        public Int32 Platform
        {
            set{ _platform=value;}
            get{return _platform;}
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
