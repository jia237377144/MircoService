using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Subtotal_price_set")]
    public class SubtotalPriceSet
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
