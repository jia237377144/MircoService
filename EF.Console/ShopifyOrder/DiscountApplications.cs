using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Discount_applications")]
    public class DiscountApplications:IAggregateRoot
    {
        public int ID { get; set; }
        public long OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value_type")]
        public string ValueType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allocation_method")]
        public string AllocationMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_selection")]
        public string TargetSelection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }

}
