using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Factory
{
    /// <summary>
    /// 这是一个产品组：格力产品族
    /// 海尔工厂包括;电视和空调
    /// （但是没有具体的空调类，所以生产的空调是杂牌空调，徒有其名）
    /// </summary>
    public class GreenFactory: AbstractFactory
    {
        public override AbstractTV MakeTv()
        {
            return new GreenTV();
        }

        public override AbstractRefrigerator MakeRefrigerator()
        {
            return base.MakeRefrigerator();
        }
    }
}
