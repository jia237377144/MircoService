/******************************************
* 模块名称：实体 用户对客服评价信息
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
	/// 实体 用户对客服评价信息
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public class user_employee_evaluation
	{
        #region 构造函数
        /// <summary>
        /// 实体 用户对客服评价信息
        /// </summary>
        public user_employee_evaluation(){}
        #endregion

        #region 私有变量
        private Int32 _id = Int32.MinValue;
        private Int32 _userid = Int32.MinValue;
        private Int32 _employeeid = Int32.MinValue;
        private Int32 _sourceid = Int32.MinValue;
        private Int32 _servicelevel = Int32.MinValue;
        private Int32 _responselevel = Int32.MinValue;
        private Int32 _replylevel = Int32.MinValue;
        private string _suggest = null;
        private DateTime _adddate = DateTime.MinValue;
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
        /// 客服ID，外键ID
        /// </summary>
        public Int32 EmployeeID
        {
            set{ _employeeid=value;}
            get{return _employeeid;}
        }
        /// <summary>
        /// 来源(和原网站保持一致，链接中如果包含该参数则获取)
        /// </summary>
        public Int32 SourceID
        {
            set{ _sourceid=value;}
            get{return _sourceid;}
        }
        /// <summary>
        /// 服务星级
        /// </summary>
        public Int32 ServiceLevel
        {
            set{ _servicelevel=value;}
            get{return _servicelevel;}
        }
        /// <summary>
        /// 应答星级
        /// </summary>
        public Int32 ResponseLevel
        {
            set{ _responselevel=value;}
            get{return _responselevel;}
        }
        /// <summary>
        /// 回答星级
        /// </summary>
        public Int32 ReplyLevel
        {
            set{ _replylevel=value;}
            get{return _replylevel;}
        }
        /// <summary>
        /// 建议内容
        /// </summary>
        public string Suggest
        {
            set{ _suggest=value;}
            get{return _suggest;}
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
