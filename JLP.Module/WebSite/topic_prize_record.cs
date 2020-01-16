/******************************************
* 模块名称：实体 专题抽奖记录
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
	/// 实体 专题抽奖记录
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_prize_record
	{
        #region 构造函数
        /// <summary>
        /// 实体 专题抽奖记录
        /// </summary>
        public topic_prize_record(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _topicid = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private string _userguid = null;
        private string _email = null;
        private Int32 _type = Int32.MinValue;
        private Int32 _orderid = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _prizeinfo = null;
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
        /// 专题ID，外键ID
        /// </summary>
        public Int32 TopicID
        {
            set{ _topicid=value;}
            get{return _topicid;}
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
        /// 用户邮箱，页面展示中奖人
        /// </summary>
        public string Email
        {
            set{ _email=value;}
            get{return _email;}
        }
        /// <summary>
        /// 抽奖类型枚举：1-正常抽奖，2-分享抽奖，3-下单抽奖
        /// </summary>
        public Int32 Type
        {
            set{ _type=value;}
            get{return _type;}
        }
        /// <summary>
        /// 下单之后，给用户的抽奖机会，需要对应的订单号
        /// </summary>
        public Int32 OrderID
        {
            set{ _orderid=value;}
            get{return _orderid;}
        }
        /// <summary>
        /// 抽奖状态枚举：0-未抽奖，1-已抽奖
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
        }
        /// <summary>
        /// 奖品信息
        /// </summary>
        public string PrizeInfo
        {
            set{ _prizeinfo=value;}
            get{return _prizeinfo;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime
        {
            set{ _addtime=value;}
            get{return _addtime;}
        }
        #endregion
	}
}
