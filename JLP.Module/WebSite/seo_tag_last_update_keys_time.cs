/******************************************
* 模块名称：实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
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
	/// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class seo_tag_last_update_keys_time
	{
        #region 构造函数
        /// <summary>
        /// 实体 SEO Tag词系统需要表，站内不负责维护，只用调取数据
        /// </summary>
        public seo_tag_last_update_keys_time(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _siteid = Int32.MinValue;
        private Int32 _lgid = Int32.MinValue;
        private DateTime _adddate = DateTime.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
        /// </summary>
        public Int32 ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 站点ID
        /// </summary>
        public Int32 SiteID
        {
            set{ _siteid=value;}
            get{return _siteid;}
        }
        /// <summary>
        /// 语言ID
        /// </summary>
        public Int32 LgID
        {
            set{ _lgid=value;}
            get{return _lgid;}
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set{ _adddate=value;}
            get{return _adddate;}
        }
        #endregion
	}
}
