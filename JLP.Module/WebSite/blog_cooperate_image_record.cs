/******************************************
* 模块名称：实体 博主合作图片表,对接pub系统的记录
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
	/// 实体 博主合作图片表,对接pub系统的记录
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class blog_cooperate_image_record
	{
        #region 构造函数
        /// <summary>
        /// 实体 博主合作图片表,对接pub系统的记录
        /// </summary>
        public blog_cooperate_image_record(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _blogcooperateimageid = Int32.MinValue;
        private string _accountusername = null;
        private Int32 _pushtype = Int32.MinValue;
        private string _pushidjson = null;
        private DateTime _pushtime = DateTime.MinValue;
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
        /// 博主图片ID，外键ID
        /// </summary>
        public Int32 BlogCooperateImageID
        {
            set{ _blogcooperateimageid=value;}
            get{return _blogcooperateimageid;}
        }
        /// <summary>
        /// 操作人ID，外键ID
        /// </summary>
        public string AccountUserName
        {
            set{ _accountusername=value;}
            get{return _accountusername;}
        }
        /// <summary>
        /// 推送类型（1:评论、2:画廊、3:产品图集）
        /// </summary>
        public Int32 PushType
        {
            set{ _pushtype=value;}
            get{return _pushtype;}
        }
        /// <summary>
        /// 评论/画廊/产品图集 ID
        /// </summary>
        public string PushIDJSON
        {
            set{ _pushidjson=value;}
            get{return _pushidjson;}
        }
        /// <summary>
        /// 推送时间
        /// </summary>
        public DateTime PushTime
        {
            set{ _pushtime=value;}
            get{return _pushtime;}
        }
        #endregion
	}
}
