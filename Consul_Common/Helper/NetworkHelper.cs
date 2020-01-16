using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consul_Common.Helper
{
    public class NetworkHelper
    {
        /// <summary>
        /// 获取当前服务运行的IP
        /// </summary>
        /// <returns></returns>
        public static string LocalIPAddress()
        {

            string localIP = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()

            .Select(p => p.GetIPProperties())

            .SelectMany(p => p.UnicastAddresses)

            .Where(p => p.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !System.Net.IPAddress.IsLoopback(p.Address))

            .FirstOrDefault()?.Address.ToString();


            return localIP;
        }
    }
}
