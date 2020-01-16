using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consul_Common.CustomConfigurationSource
{
    /// <summary>
    /// 定义数据源
    /// </summary>
    public class ConsulConfigurationSource : IConfigurationSource
    {

        public IEnumerable<Uri> ConsulUrls { get; }
        public string Path { get; }

        public ConsulConfigurationSource(IEnumerable<Uri> consulUrls, string path)
        {
            ConsulUrls = consulUrls;
            Path = path;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new ConsulConfigurationProvider(ConsulUrls, Path);
        }
    }
}
