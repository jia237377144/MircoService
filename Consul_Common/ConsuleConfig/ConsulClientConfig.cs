using System;
using System.Collections.Generic;
using System.Text;

namespace Consul_Common.ConsuleConfig
{
    /// <summary>
    /// Consul 客户端节点信息
    /// </summary>
    public class ConsulClientConfig
    {
        public string IP { get; set; }
        public int Port { get; set; }
    }
}
