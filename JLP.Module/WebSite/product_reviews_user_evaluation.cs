/******************************************
* 模块名称：实体 用户对产品评论评价表
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
	/// 实体 用户对产品评论评价表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_reviews_user_evaluation
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户对产品评论评价表
        /// </summary>
        public product_reviews_user_evaluation(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _pid = Int32.MinValue;
        private Int32 _reviewid = Int32.MinValue;
        private Int32 _evaluationstatus = Int32.MinValue;
        private DateTime _addtime = DateTime.MinValue;
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
        /// SPUID，外键ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 产品URL的ID，外键ID
        /// </summary>
        public Int32 PID
        {
            set{ _pid=value;}
            get{return _pid;}
        }
        /// <summary>
        /// 评论ID，外键ID
        /// </summary>
        public Int32 ReviewID
        {
            set{ _reviewid=value;}
            get{return _reviewid;}
        }
        /// <summary>
        /// 评价类型(枚举类型：USEFUL, USELESS)
        /// </summary>
        public Int32 EvaluationStatus
        {
            set{ _evaluationstatus=value;}
            get{return _evaluationstatus;}
        }
        /// <summary>
        /// 评价添加时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        #endregion
	}
}
