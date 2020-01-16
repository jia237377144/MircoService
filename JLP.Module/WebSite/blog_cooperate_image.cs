/******************************************
* 模块名称：实体 博主合作图片表,对接pub系统
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
	/// 实体 博主合作图片表,对接pub系统
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class blog_cooperate_image
	{
        #region 构造函数
        /// <summary>
        /// 实体 博主合作图片表,对接pub系统
        /// </summary>
        public blog_cooperate_image(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _type = Int32.MinValue;
        private string _src = null;
        private Int32 _width = Int32.MinValue;
        private Int32 _height = Int32.MinValue;
        private string _evaluate = null;
        private string _cooperateuseremail = null;
        private string _blogchargeemail = null;
        private DateTime _selectiontime = DateTime.MinValue;
        private Int32 _ispushtoreview = Int32.MinValue;
        private Int32 _ispushtogallery = Int32.MinValue;
        private Int32 _ispushtoproduct = Int32.MinValue;
        private DateTime _pushtime = DateTime.MinValue;
        private string _pushuseremail = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _createusername = null;
        private DateTime _updatetime = DateTime.MinValue;
        private string _updateusername = null;
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
        /// SPUID，外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 类型(图片/视频)
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 图片/视频地址
        /// </summary>
        public string Src
        {
            set{ _src=value;}
            get{return _src;}
        }
        /// <summary>
        /// 图片宽度
        /// </summary>
        public Int32 Width
        {
            set{ _width=value;}
            get{return _width;}
        }
        /// <summary>
        /// 图片高度
        /// </summary>
        public Int32 Height
        {
            set{ _height=value;}
            get{return _height;}
        }
        /// <summary>
        /// 博主评价
        /// </summary>
        public string Evaluate
        {
            set{ _evaluate=value;}
            get{return _evaluate;}
        }
        /// <summary>
        /// 合作博主邮箱
        /// </summary>
        public string CooperateUserEmail
        {
            set{ _cooperateuseremail=value;}
            get{return _cooperateuseremail;}
        }
        /// <summary>
        /// 博主负责人邮箱
        /// </summary>
        public string BlogChargeEmail
        {
            set{ _blogchargeemail=value;}
            get{return _blogchargeemail;}
        }
        /// <summary>
        /// 选款时间
        /// </summary>
        public DateTime SelectionTime
        {
            set{ _selectiontime=value;}
            get{return _selectiontime;}
        }
        /// <summary>
        /// 是推送到评论
        /// </summary>
        public Int32 IsPushToReview
        {
            set{ _ispushtoreview=value;}
            get{return _ispushtoreview;}
        }
        /// <summary>
        /// 是否推送到画廊
        /// </summary>
        public Int32 IsPushToGallery
        {
            set{ _ispushtogallery=value;}
            get{return _ispushtogallery;}
        }
        /// <summary>
        /// 是否推送到产品图集
        /// </summary>
        public Int32 IsPushToProduct
        {
            set{ _ispushtoproduct=value;}
            get{return _ispushtoproduct;}
        }
        /// <summary>
        /// 推送时间
        /// </summary>
        public DateTime PushTime
        {
            set{ _pushtime=value;}
            get{return _pushtime;}
        }
        /// <summary>
        /// 推送人邮箱
        /// </summary>
        public string PushUserEmail
        {
            set{ _pushuseremail=value;}
            get{return _pushuseremail;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// 创建用户名
        /// </summary>
        public string CreateUserName
        {
            set{ _createusername=value;}
            get{return _createusername;}
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// 修改用户名
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
