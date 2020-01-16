using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.Model
{
    public class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int State { get; set; }

        public DateTime SyncTime { get; set; } = new DateTime(1900, 1, 1);

        public int SyncState { get; set; }

    }
}
