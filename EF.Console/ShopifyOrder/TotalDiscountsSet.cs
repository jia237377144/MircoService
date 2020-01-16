using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Total_discounts_set")]
    public class TotalDiscountsSet
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shop_money")]
        public ShopMoney ShopMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("presentment_money")]
        public PresentmentMoney PresentmentMoney { get; set; }
    }

}
