using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Amount_set")]
    public class AmountSet
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
