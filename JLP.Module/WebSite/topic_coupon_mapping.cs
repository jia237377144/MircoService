/******************************************
* 模块名称：实体 专题和系统优惠券的关联表
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
	/// 实体 专题和系统优惠券的关联表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_coupon_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题和系统优惠券的关联表
        /// </summary>
        public topic_coupon_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topicid = Int32.MinValue;
        private Int32 _couponid = Int32.MinValue;
        private Int32 _coupontype = Int32.MinValue;
        private string _word = null;
        private string _src = null;
        private Int32 _sort = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private string _url = null;
        private string _platformjson = null;
        private Int32 _iscountdown = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
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
        /// 专题信息ID，外键ID
        /// </summary>
        public Int32 TopicID
        {
            set{ _topicid=value;}
            get{return _topicid;}
        }
        /// <summary>
        /// 优惠券ID，外键ID
        /// </summary>
        public Int32 CouponID
        {
            set{ _couponid=value;}
            get{return _couponid;}
        }
        /// <summary>
        /// 优惠券类型
        /// </summary>
        public Int32 CouponType
        {
            set{ _coupontype=value;}
            get{return _coupontype;}
        }
        /// <summary>
        /// 文字描述
        /// </summary>
        public string Word
        {
            set{ _word=value;}
            get{return _word;}
        }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string Src
        {
            set{ _src=value;}
            get{return _src;}
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
        /// 广告位ID（自定义编号）
        /// </summary>
        public Int32 PositionID
        {
            set{ _positionid=value;}
            get{return _positionid;}
        }
        /// <summary>
        /// 跳转链接
        /// </summary>
        public string URL
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 平台枚举：PC，M，APP
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 是否倒计时枚举（是=1，否=0）
        /// </summary>
        public Int32 IsCountDown
        {
            set{ _iscountdown=value;}
            get{return _iscountdown;}
        }
        /// <summary>
        /// 状态
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
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
