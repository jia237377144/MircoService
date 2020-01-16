using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JLP.WebApi.Ef.Models
{
    public class PropertyValue
    {
        public int ID { get; set; }
        public int KeyID { get; set; }
        public int ValueID { get; set; }
        public int Sort { get; set; }
        public string ValueText { get; set; }
        /// <summary>
        /// 是否在前台显示
        /// </summary>
        public int Status { get; set; }
    }
}