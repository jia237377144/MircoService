using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Factory
{
    /// <summary>
    /// 抽象工厂类
    /// 定义所有的产品等级结构
    /// </summary>
    public partial class AbstractFactory
    {
        /// <summary>
        /// 电视
        /// </summary>
        public virtual AbstractTV MakeTv() { return new AbstractTV(); }
        /// <summary>
        /// 空调
        /// </summary>
        public virtual AbstractAC MakeAc() { return new AbstractAC(); }

    }

    public partial class AbstractFactory
    {
        public virtual AbstractRefrigerator MakeRefrigerator() { return new AbstractRefrigerator(); }
    }





}
