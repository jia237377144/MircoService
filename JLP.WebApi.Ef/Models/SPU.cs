using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JLP.WebApi.Ef.Models
{
    public class SPU
    {
        /// <summary>
        /// 产品数据
        /// </summary>
        public TB_Product Product { get; set; }
        /// <summary>
        /// 类目集合
        /// </summary>
        public List<TB_Category> CategoryList { get; set; }
        /// <summary>
        /// 属性集合
        /// </summary>
        public List<PropertyValue> PropertyValueList { get; set; }

        /// <summary>
        /// 图片集合
        /// </summary>
        public List<Image> ImageList { get; set; }

        /// <summary>
        /// SKU列表
        /// </summary>
        public List<ProductSKU> SkuList { get; set; }

        /// <summary>
        /// 必选区键
        /// </summary>
        public List<TB_RequiredKey> RequireKeyList { get; set; }

        /// <summary>
        /// 必选区值
        /// </summary>
        public List<TB_RequiredValue> RequireValueList { get; set; }
    }
}