using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Factory
{
    /// <summary>
    /// 抽象类-- 电视
    /// 产品等级结构
    /// </summary>
    public class AbstractTV
    {
        public string BrandName { get; set; } = "杂牌";

        public virtual void DisplayAd()
        {
            Console.WriteLine($"The TV is : {this.BrandName}");
        }

    }
}
