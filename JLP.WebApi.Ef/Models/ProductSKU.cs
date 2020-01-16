using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JLP.WebApi.Ef.Models
{
    /// <summary>
    /// 产品编辑页的SKU
    /// </summary>
    public class ProductSKU : TB_SKU
    {
        public Dictionary<string, int> RequiredKeyValueDict { get; set; }
    }

    /// <summary>
    /// TB_SKU
    /// </summary>
    public class TB_SKU
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// SKUID
        /// </summary>
        public int SKUID { get; set; }
        /// <summary>
        /// SPUID
        /// </summary>
        public int SPUID { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// ImageUrl
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// IsShow
        /// </summary>
        public int IsShow { get; set; }
        /// <summary>
        /// SpecificationText
        /// </summary>
        public string SpecificationText { get; set; }
        /// <summary>
        /// SpecificationCode
        /// </summary>
        public string SpecificationCode { get; set; }
        /// <summary>
        /// IsValid
        /// </summary>
        public int IsValid { get; set; }
        /// <summary>
        /// ProductID
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// LeadTimeMin
        /// </summary>
        public int LeadTimeMin { get; set; }
        /// <summary>
        /// LeadTimeMax
        /// </summary>
        public int LeadTimeMax { get; set; }
        /// <summary>
        /// StockCount
        /// </summary>
        public int StockCount { get; set; }
        /// <summary>
        /// IsDefault
        /// </summary>
        public int IsDefault { get; set; }
        /// <summary>
        /// SkuType
        /// </summary>
        public int SkuType { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// SiteID
        /// </summary>
        public int SiteID { get; set; }
        /// <summary>
        /// OriginalPC
        /// </summary>
        public decimal OriginalPC { get; set; }
        /// <summary>
        /// OriginalM
        /// </summary>
        public decimal OriginalM { get; set; }
        /// <summary>
        /// OriginalAPP
        /// </summary>
        public decimal OriginalAPP { get; set; }
        /// <summary>
        /// PricePC
        /// </summary>
        public decimal PricePC { get; set; }
        /// <summary>
        /// PriceM
        /// </summary>
        public decimal PriceM { get; set; }
        /// <summary>
        /// PriceAPP
        /// </summary>
        public decimal PriceAPP { get; set; }
        /// <summary>
        /// CostPrice
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// MarketPrice
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// PlatformJSON
        /// </summary>
        public string PlatformJSON { get; set; }
        /// <summary>
        /// MinBuyCount
        /// </summary>
        public int MinBuyCount { get; set; }
        /// <summary>
        /// MaxBuyCount
        /// </summary>
        public int MaxBuyCount { get; set; }

    }
}