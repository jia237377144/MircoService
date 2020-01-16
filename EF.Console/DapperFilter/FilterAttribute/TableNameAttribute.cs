using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperFilter.FilterAttribute
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =false)]
    public class TableNameAttribute:Attribute
    {
        public string Name { get; set; }

        public TableNameAttribute(string name)
        {
            this.Name = name;
        }

    }
}
