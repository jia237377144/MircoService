using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consul_Watch.Module
{
    /// <summary>
    /// 报警消息实体
    /// </summary>
    public class Notification
    {
        public string Node { get; set; }
        public string ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string CheckID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Output { get; set; }
    }
}
