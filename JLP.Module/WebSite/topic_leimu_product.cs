/******************************************
* 模块名称：实体 推荐类目自定义产品
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
	/// 实体 推荐类目自定义产品
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class topic_leimu_product
	{
        #region 构造函数
        /// <summary>
        /// 实体 推荐类目自定义产品
        /// </summary>
        public topic_leimu_product(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _labelid = Int32.MinValue;
        private Int32 _infoid = Int32.MinValue;
        private Int32 _moduleid = Int32.MinValue;
        private Int32 _templateid = Int32.MinValue;
        private Int32 _positionid = Int32.MinValue;
        private Int32 _cultureid = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private string _name = null;
        private Int32 _leimuid = Int32.MinValue;
        private string _leimuname = null;
        private string _platformjson = null;
        private string _src = null;
        private string _url = null;
        private Int32 _sort = Int32.MinValue;
        private decimal _price = decimal.MinValue;
        private DateTime _starttime = DateTime.MinValue;
        private DateTime _endtime = DateTime.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _lastupdatecontent = null;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
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
        /// 标签ID，外键ID
        /// </summary>
        public Int32 LabelID
        {
            set{ _labelid=value;}
            get{return _labelid;}
        }
        /// <summary>
        /// 专题信息ID，外键ID
        /// </summary>
        public Int32 InfoID
        {
            set{ _infoid=value;}
            get{return _infoid;}
        }
        /// <summary>
        /// 模块ID，关联一个模块内的标签、产品、图片等
        /// </summary>
        public Int32 ModuleID
        {
            set{ _moduleid=value;}
            get{return _moduleid;}
        }
        /// <summary>
        /// 模板ID，外键ID
        /// </summary>
        public Int32 TemplateID
        {
            set{ _templateid=value;}
            get{return _templateid;}
        }
        /// <summary>
        /// 广告位ID，枚举类型ID
        /// </summary>
        public Int32 PositionID
        {
            set{ _positionid=value;}
            get{return _positionid;}
        }
        /// <summary>
        /// 多语言ID，外键ID
        /// </summary>
        public Int32 CultureID
        {
            set{ _cultureid=value;}
            get{return _cultureid;}
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
        /// 产品多语言的名称
        /// </summary>
        public string Name
        {
            set{ _name=value;}
            get{return _name;}
        }
        /// <summary>
        /// 类目ID，外键ID
        /// </summary>
        public Int32 LeiMuID
        {
            set{ _leimuid=value;}
            get{return _leimuid;}
        }
        /// <summary>
        /// 类目多语言的名称
        /// </summary>
        public string LeiMuName
        {
            set{ _leimuname=value;}
            get{return _leimuname;}
        }
        /// <summary>
        /// 广告使用平台枚举：PC，M，APP
        /// </summary>
        public string PlatformJSON
        {
            set{ _platformjson=value;}
            get{return _platformjson;}
        }
        /// <summary>
        /// 产品图片Src
        /// </summary>
        public string Src
        {
            set{ _src=value;}
            get{return _src;}
        }
        /// <summary>
        /// 连接页面的Url
        /// </summary>
        public string Url
        {
            set{ _url=value;}
            get{return _url;}
        }
        /// <summary>
        /// 排序编号
        /// </summary>
        public Int32 Sort
        {
            set{ _sort=value;}
            get{return _sort;}
        }
        /// <summary>
        /// 价格，设置单独的价格
        /// </summary>
        public decimal Price
        {
            set{ _price=value;}
            get{return _price;}
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime
        {
            set{ _starttime=value;}
            get{return _starttime;}
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime
        {
            set{ _endtime=value;}
            get{return _endtime;}
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
        /// 最后一个编辑人的修改内容
        /// </summary>
        public string LastUpdateContent
        {
            set{ _lastupdatecontent=value;}
            get{return _lastupdatecontent;}
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
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
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
        /// UpdateUserName
        /// </summary>
        public string UpdateUserName
        {
            set{ _updateusername=value;}
            get{return _updateusername;}
        }
        #endregion
	}
}
