using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Discount_codes")]
    public class DiscountCodes:IAggregateRoot
    {
        public int ID { get; set; }
        public long OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
