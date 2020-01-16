/******************************************
* 模块名称：实体 产品副标题明细表
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
	/// 实体 产品副标题明细表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_subtitle_details
	{
        #region 构造函数
        /// <summary>
        /// 实体 产品副标题明细表
        /// </summary>
        public product_spu_subtitle_details(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _subtitlemasterid = Int32.MinValue;
        private Int32 _typevalue = Int32.MinValue;
        private Int32 _status = Int32.MinValue;
        private string _createusername = null;
        private DateTime _createtime = DateTime.MinValue;
        private string _updateusername = null;
        private DateTime _updatetime = DateTime.MinValue;
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
        /// 产品副标题主表ID，外键ID
        /// </summary>
        public Int32 SubTitleMasterID
        {
            set{ _subtitlemasterid=value;}
            get{return _subtitlemasterid;}
        }
        /// <summary>
        /// 类型值[如果是主表选的是A,B两个类目,这个表会有两个记录,A和B,SpuId和类目一样。方便前台查询]
        /// </summary>
        public Int32 TypeValue
        {
            set{ _typevalue=value;}
            get{return _typevalue;}
        }
        /// <summary>
        /// 状态枚举[0删除,1正常],有可能和主表不一致,因为主表可以编辑类型值,会添加和删除。
        /// </summary>
        public Int32 Status
        {
            set{ _status=value;}
            get{return _status;}
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
