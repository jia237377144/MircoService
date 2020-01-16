using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.Console.ShopifyOrder
{

    [JsonObject("Order")]
    public class Order : IAggregateRoot
    {
        public int ID { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("closed_at")]
        private DateTime _closedAt;
        public DateTime ClosedAt //{ get; set; }
        {
            get { return this._closedAt; }
            set { if (value == DateTime.MinValue) { this._closedAt = new DateTime(1900, 1, 1); } else { this._closedAt = value; } }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_at")]
        private DateTime _createdAt;
        public DateTime CreatedAt //{ get; set; }
        {
            get { return this._createdAt; }
            set { if (value == DateTime.MinValue) { this._createdAt = new DateTime(1900, 1, 1); } else { this._createdAt = value; } }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updated_at")]
        private DateTime _updatedAt;
        public DateTime UpdatedAt //{ get; set; }
        {
            get { return this._updatedAt; }
            set
            {
                if (value == DateTime.MinValue) { this._updatedAt = new DateTime(1900, 1, 1); } else { this._updatedAt = value; }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("test")]
        public bool Test { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_price")]
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subtotal_price")]
        public decimal SubtotalPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_weight")]
        public int TotalWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_tax")]
        public decimal TotalTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taxes_included")]
        public bool TaxesIncluded { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_discounts")]
        public decimal TotalDiscounts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_line_items_price")]
        public decimal TotalLineItemsPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cart_token")]
        public string CartToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("buyer_accepts_marketing")]
        public bool BuyerAcceptsMarketing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cancelled_at")]
        private DateTime _cancelledAt;
        public DateTime CancelledAt //{ get; set; }
        {
            get { return this._cancelledAt; }
            set
            {
                if (value == DateTime.MinValue) { this._cancelledAt = new DateTime(1900, 1, 1); } else { this._cancelledAt = value; }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_price_usd")]
        public decimal TotalPriceUsd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("checkout_token")]
        public string CheckoutToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_identifier")]
        public string SourceIdentifier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("processed_at")]
        private DateTime _processedAt;
        public DateTime ProcessedAt //{ get; set; }
        {
            get { return this._processedAt; }
            set
            {
                if (value == DateTime.MinValue) { this._processedAt = new DateTime(1900, 1, 1); } else { this._processedAt = value; }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("customer_locale")]
        public string CustomerLocale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_id")]
        public long AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("landing_site_ref")]
        public string LandingSiteRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("discount_applications")]
        public List<DiscountApplications> DiscountApplications { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("discount_codes")]
        public List<DiscountCodes> DiscountCodes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("note_attributes")]
        public List<string> NoteAttributes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment_gateway_names")]
        public List<string> PaymentGatewayNames { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("processing_method")]
        public string ProcessingMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("checkout_id")]
        public string CheckoutId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_name")]
        public string SourceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tax_lines")]
        public List<string> TaxLines { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order_status_url")]
        public string OrderStatusUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("presentment_currency")]
        public string PresentmentCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_line_items_price_set")]
        public TotalLineItemsPriceSet TotalLineItemsPriceSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_discounts_set")]
        public TotalDiscountsSet TotalDiscountsSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_shipping_price_set")]
        public TotalShippingPriceSet TotalShippingPriceSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subtotal_price_set")]
        public SubtotalPriceSet SubtotalPriceSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_price_set")]
        public TotalPriceSet TotalPriceSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_tax_set")]
        public TotalTaxSet TotalTaxSet { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonProperty("total_tip_received")]
        //public string TotalTipReceived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("line_items")]
        public List<LineItems> LineItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shipping_lines")]
        public List<string> ShippingLines { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fulfillments")]
        public List<string> Fulfillments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("refunds")]
        public List<string> Refunds { get; set; }

    }



}
