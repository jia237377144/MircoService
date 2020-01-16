using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using Microsoft.Extensions.Logging;

namespace Consul_Common.CustomConfigurationSource
{
    /// <summary>
    /// 自定义配置数据源提供器
    /// </summary>
    public class ConsulConfigurationProvider : ConfigurationProvider
    {
        private const string ConsulIndexHeader = "X-Consul-Index";
        /// <summary>
        /// 数据节点
        /// 如： {"WebApi":{"log":"Debuger","connectionstring":"localhost"}}
        /// WebApi
        /// </summary>
        private readonly string _path;

        /// <summary>
        /// ConsulServer地址
        /// </summary>
        private readonly IReadOnlyList<Uri> _consulUrls;
        private readonly HttpClient _httpClient;
        private readonly Task _configurationListeningTask;
        private int _consulUrlIndex;
        private int _failureCount;
        private int _consulConfigurationIndex;

        public ConsulConfigurationProvider(IEnumerable<Uri> consulUrls, string path)
        {
            _path = path;
            _consulUrls = consulUrls.Select(u => new Uri(u, $"v1/kv/{path}")).ToList();

            if (_consulUrls.Count <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(consulUrls));
            }

            _httpClient = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip }, true);
            _configurationListeningTask = new Task(ListenToConfigurationChanges);
        }

        /// <summary>
        /// 重写基类方法
        /// </summary>
        public override void Load() => LoadAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        private async Task LoadAsync()
        {
            Data = await ExecuteQueryAsync();

            if (_configurationListeningTask.Status == TaskStatus.Created)
                _configurationListeningTask.Start();
        }

        /// <summary>
        /// 监听 Consul中KV是否变化，执行重新加载
        /// </summary>
        private async void ListenToConfigurationChanges()
        {
            while (true)
            {
                try
                {
                    if (_failureCount > _consulUrls.Count)
                    {
                        _failureCount = 0;
                        await Task.Delay(TimeSpan.FromMinutes(1));
                    }

                    Data = await ExecuteQueryAsync(true);
                    OnReload();
                    _failureCount = 0;
                }
                catch (TaskCanceledException)
                {
                    _failureCount = 0;
                }
                catch
                {
                    _consulUrlIndex = (_consulUrlIndex + 1) % _consulUrls.Count;
                    _failureCount++;
                }
            }
        }

        private async Task<IDictionary<string, string>> ExecuteQueryAsync(bool isBlocking = false)
        {
            var requestUri = isBlocking ? $"?recurse=true&index={_consulConfigurationIndex}" : "?recurse=true";
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning);
                builder.AddFilter((content, result) =>
                {
                    Console.WriteLine(content);
                    return true;
                });
            });
            ILogger logger = loggerFactory.CreateLogger<ConsulConfigurationProvider>();
            logger.LogInformation($"ConsulConfigurationProvider URL：{_consulUrls[_consulUrlIndex]},requestUri:{requestUri}");

            var uri = new Uri(_consulUrls[_consulUrlIndex], requestUri);
            using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                using (var response = await _httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    if (response.Headers.Contains(ConsulIndexHeader))
                    {
                        var indexValue = response.Headers.GetValues(ConsulIndexHeader).FirstOrDefault();
                        int.TryParse(indexValue, out _consulConfigurationIndex);
                    }

                    var tokens = JToken.Parse(await response.Content.ReadAsStringAsync());

                    List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

                    string key = string.Empty;
                    string value = string.Empty;
                    JToken configValue = null;
                    foreach (var k in tokens)
                    {
                        key = k["Key"].ToString();
                        if (!string.IsNullOrWhiteSpace(key))
                        {
                            value = k["Value"].ToString();
                            configValue = string.IsNullOrWhiteSpace(value) ? null : JToken.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(value)));
                            var data = Flatten(configValue);
                            list.AddRange(data);
                        }

                    }
                    var dict = list.ToDictionary(x => x.Key, x => x.Value);
                    return dict;
                }
            }
        }

        private static List<KeyValuePair<string, string>> Flatten(JToken jsonToken)
        {
            if (!(jsonToken is JObject value))
                return new List<KeyValuePair<string, string>>(0);
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
            foreach (var property in value)
            {
                result.Add(new KeyValuePair<string, string>(property.Key, property.Value.ToString()));
            }
            return result;
        }
    }
}
