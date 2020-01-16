using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.CustomConfig
{
    class ComplexSection : ConfigurationSection
    {
        [ConfigurationProperty("height", IsRequired = true, DefaultValue = 10)]
        public int Height
        {
            get
            {
                return (int)base["height"];
            }
            set
            {
                base["height"] = value;
            }
        }

        [ConfigurationProperty("child", IsDefaultCollection = false)]
        public ChildSection Child
        {
            get
            {
                return (ChildSection)base["child"];
            }
            set
            {
                base["child"] = value;
            }
        }

        [ConfigurationProperty("children", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ChildSection), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap, RemoveItemName = "remove")]
        public Children Children
        {
            get
            {
                return (Children)base["children"];
            }
            set
            {
                base["children"] = value;
            }
        }

        [ConfigurationProperty("NVs", IsDefaultCollection = false)]
        public NameValueConfigurationCollection Nvs
        {
            get
            {
                return (NameValueConfigurationCollection)base["NVs"];
            }
            set
            {
                base["NVs"] = value;
            }
        }



    }

    class ChildSection : ConfigurationElement
    {
        [ConfigurationProperty("firstName", IsRequired = false, IsKey = true, DefaultValue = "firstName")]
        public string FirstName
        {
            get
            {
                return (string)base["firstName"];
            }
            set
            {
                base["firstName"] = value;
            }
        }
        [ConfigurationProperty("lastName", IsRequired = false, DefaultValue = "lastName")]
        public string LastName
        {
            get
            {
                return (string)base["lastName"];
            }
            set
            {
                base["lastName"] = value;
            }
        }

    }


    class Children : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ChildSection();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ChildSection)element).FirstName;
        }
    }
}
