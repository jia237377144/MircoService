/******************************************
* 模块名称：实体 用户收藏的产品
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
	/// 实体 用户收藏的产品
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class spu_user_favorite
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户收藏的产品
        /// </summary>
        public spu_user_favorite(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _userguid = null;
        private Int32 _pid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _skuid = Int32.MinValue;
        private string _specificationtext = null;
        private string _specificationcode = null;
        private string _leavemessage = null;
        private DateTime _intotime = DateTime.MinValue;
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
        /// 用户ID，外键ID
        /// </summary>
        public Int32 UserID
        {
            set{ _userid=value;}
            get{return _userid;}
        }
        /// <summary>
        /// 用户唯一标示（未登录时存cookie的唯一标识）
        /// </summary>
        public string UserGuid
        {
            set{ _userguid=value;}
            get{return _userguid;}
        }
        /// <summary>
        /// 网站端SPU的ID
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
        /// SKUID
        /// </summary>
        public Int32 SKUID
        {
            set{ _skuid=value;}
            get{return _skuid;}
        }
        /// <summary>
        /// 必选区值
        /// </summary>
        public string SpecificationText
        {
            set{ _specificationtext=value;}
            get{return _specificationtext;}
        }
        /// <summary>
        /// SpecificationCode
        /// </summary>
        public string SpecificationCode
        {
            set{ _specificationcode=value;}
            get{return _specificationcode;}
        }
        /// <summary>
        /// 用户留言
        /// </summary>
        public string LeaveMessage
        {
            set{ _leavemessage=value;}
            get{return _leavemessage;}
        }
        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime InToTime
        {
            set{ _intotime=value;}
            get{return _intotime;}
        }
        #endregion
	}
}
