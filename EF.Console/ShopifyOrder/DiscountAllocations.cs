using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Discount_allocations")]
    public class DiscountAllocations:IAggregateRoot
    {
        public int ID { get; set; }
        public long OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("discount_application_index")]
        public int DiscountApplicationIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amount_set")]
        public AmountSet AmountSet { get; set; }
    }

}
