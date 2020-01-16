using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Price_set")]
    public class PriceSet
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
