using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.CustomConfig
{
    class SimpleSection : ConfigurationSection
    {
        [ConfigurationProperty("maxValue", IsRequired = true, DefaultValue = int.MaxValue)]
        public int MaxValue
        {
            get
            {
                return (int)base["maxValue"];
            }
            set
            {
                base["maxValue"] = value;
            }
        }


        [ConfigurationProperty("minValue", IsRequired = true, DefaultValue = 1)]
        public int MinValue
        {
            get
            {
                return (int)base["minValue"];
            }
            set
            {
                base["minValue"] = value;
            }
        }


        [ConfigurationProperty("enable", IsRequired = false, DefaultValue = false)]
        public bool Enable
        {
            get
            {
                return (bool)base["enable"];
            }
            set
            {
                base["enable"] = value;
            }
        }
    }
}
