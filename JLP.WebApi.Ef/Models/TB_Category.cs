using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JLP.WebApi.Ef.Models
{
    public class TB_Category
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string CNName { get; set; }
        public int ProductCount { get; set; }
        public string ParentIDs { get; set; }
        public int Sort { get; set; }
        public string Logo { get; set; }
        public int ShowType { get; set; }
        public int FakeLevel { get; set; }
        public int State { get; set; }
        public int SiteID { get; set; }
        public string TitleTags { get; set; }
        public string KeywordsTags { get; set; }
        public string DescriptionTags { get; set; }
        public string Description { get; set; }
        public decimal CustomPrice { get; set; }
        public int ProductCount1 { get; set; }
        public int CategoryNameID { get; set; }
        public int IsShow { get; set; }
        public string DefaultUrl { get; set; }
        public string FirstWord { get; set; }
        public string RedirectUrl { get; set; }
        public int IsUserCustomImage { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public int ImageQuality { get; set; }
        public string RedirectUrl301 { get; set; }
        public int Type { get; set; }
        public string urlSign { get; set; }
        public string LogoDesc { get; set; }
    }
}