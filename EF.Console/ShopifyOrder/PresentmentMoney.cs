using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Presentment_money")]
    public class PresentmentMoney: IAggregateRoot
    {
        public int ID { get; set; }
        public long OrderId { get; set; }
        /// <summary>
        /// 所属字段类型 枚举值EOrderPropertyType
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }

}
