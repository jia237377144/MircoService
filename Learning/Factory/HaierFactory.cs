using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Factory
{
    /// <summary>
    /// 这是一个产品组：海尔产品族
    /// 海尔工厂包括;电视和空调
    /// </summary>
    public class HaierFactory:AbstractFactory
    {
        public override AbstractAC MakeAc()
        {
            return new HaierAC();
        }

        public override AbstractTV MakeTv()
        {
            return new HaierTV();
        }

    }
}
