/******************************************
* 模块名称：实体 识别用户访问网站的唯一标示，（仅在用户访问网站后，登录和注册时才需要写入此表）
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
	/// 实体 识别用户访问网站的唯一标示，（仅在用户访问网站后，登录和注册时才需要写入此表）
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_cookie_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 识别用户访问网站的唯一标示，（仅在用户访问网站后，登录和注册时才需要写入此表）
        /// </summary>
        public user_cookie_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _userguid = null;
        private string _domain = null;
        private DateTime _createtime = DateTime.MinValue;
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
        /// 用户编号，外键ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 登录用户ID，0表示未登录（Cookie值）
        /// </summary>
        public string UserGuid
        {
            set{ _userguid=value;}
            get{return _userguid;}
        }
        /// <summary>
        /// 用户访问网站的域名
        /// </summary>
        public string Domain
        {
            set{ _domain=value;}
            get{return _domain;}
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
