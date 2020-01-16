using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JLP.WebApi.Ef.Models
{
    public class TB_Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime AddDate { get; set; }
        public string Images { get; set; }
        public int Unit { get; set; }
        public int MinNum { get; set; }
        public int SaleCount { get; set; }
        public int Views { get; set; }
        public string CategoryIDs { get; set; }
        public string ParentIDs { get; set; }
        public int State { get; set; }
        public int FakeLevel { get; set; }
        public decimal ProductLength { get; set; }
        public decimal ProductWide { get; set; }
        public decimal ProductHeight { get; set; }
        public decimal ProductWeight { get; set; }
        public string Remark { get; set; }
        public decimal Original { get; set; }
        public int Review { get; set; }
        public int ReviewPoint { get; set; }
        public int LotNum { get; set; }
        public decimal Price { get; set; }
        public decimal MarketPrice { get; set; }
        public int Shipping { get; set; }
        public int SiteID { get; set; }
        public decimal ProductNetWeight { get; set; }
        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public int Sort { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public DateTime EndDate { get; set; }
        public string TagID { get; set; }
        public string PrepareDate { get; set; }
        public int PromotionType { get; set; }
        public int IsNew { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime IsNewDate { get; set; }
        public int StudioID { get; set; }
        public string TitleUrl { get; set; }
        public int IsHot { get; set; }
        public int Is24H { get; set; }
        public int ProductCategory { get; set; }
        public int PmsCategoryID { get; set; }
        public int SPUID { get; set; }
        public string ImageDescription { get; set; }
        public int MaxNum { get; set; }

        public int IsGraphCustomization { get; set; }

        public int IsEngraved { get; set; }
    }

    public class TB_ProductEqualityComparer : IEqualityComparer<TB_Product>
    {
        public bool Equals(TB_Product x, TB_Product y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(TB_Product obj)
        {
            return obj.GetHashCode();
        }
    }
}