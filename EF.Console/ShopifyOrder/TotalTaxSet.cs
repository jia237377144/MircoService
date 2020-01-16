using Newtonsoft.Json;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Total_tax_set")]
    public class TotalTaxSet
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
