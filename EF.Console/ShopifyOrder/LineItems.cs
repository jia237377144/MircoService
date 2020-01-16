using Newtonsoft.Json;
using System.Collections.Generic;

namespace EF.Console.ShopifyOrder
{
    [JsonObject("Line_items")]
    public class LineItems:IAggregateRoot
    {
        public int ID { get; set; }
        public long OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long ItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("variant_id")]
        public long VariantId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("variant_title")]
        public string VariantTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fulfillment_service")]
        public string FulfillmentService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_id")]
        public long ProductId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gift_card")]
        public bool GiftCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("variant_inventory_management")]
        public string VariantInventoryManagement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties")]
        public List<string> Properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_exists")]
        public bool ProductExists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fulfillable_quantity")]
        public int FulfillableQuantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("grams")]
        public int Grams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_discount")]
        public decimal TotalDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("price_set")]
        public PriceSet PriceSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_discount_set")]
        public TotalDiscountsSet TotalDiscountSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("discount_allocations")]
        public List<DiscountAllocations> DiscountAllocations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tax_lines")]
        public List<string> TaxLines { get; set; }
    }

}
