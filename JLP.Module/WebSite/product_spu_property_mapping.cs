/******************************************
* 模块名称：实体 SPU和属性关系表
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
	/// 实体 SPU和属性关系表
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class product_spu_property_mapping
	{
        #region 构造函数
        /// <summary>
        /// 实体 SPU和属性关系表
        /// </summary>
        public product_spu_property_mapping(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _spuid = Int32.MinValue;
        private Int32 _propertykeyid = Int32.MinValue;
        private Int32 _propertyvalueid = Int32.MinValue;
        private Int32 _syncstatus = Int32.MinValue;
        private DateTime _createtime = DateTime.MinValue;
        private DateTime _updatetime = DateTime.MinValue;
        private string _createusername = null;
        private string _updateusername = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 自增ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// SPUID(外键),自己这边自增的ID
        /// </summary>
        public Int32 SPUID
        {
            set{ _spuid=value;}
            get{return _spuid;}
        }
        /// <summary>
        /// 属性键ID(外键),自己这边自增的ID
        /// </summary>
        public Int32 PropertyKeyID
        {
            set{ _propertykeyid=value;}
            get{return _propertykeyid;}
        }
        /// <summary>
        /// 属性值ID(外键),自己这边自增的ID
        /// </summary>
        public Int32 PropertyValueID
        {
            set{ _propertyvalueid=value;}
            get{return _propertyvalueid;}
        }
        /// <summary>
        /// PMS同步状态（有效=1，无效=0）
        /// </summary>
        public Int32 SyncStatus
        {
            set{ _syncstatus=value;}
            get{return _syncstatus;}
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
