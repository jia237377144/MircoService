using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Factory
{
    class GreenTV: AbstractTV
    {
        public GreenTV()
        {
            this.BrandName = "GreenTV";
        }

        public override void DisplayAd()
        {
            Console.WriteLine("I am a GreenTV!");
        }

    }
}
