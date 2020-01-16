using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JLP.WebApi.Ef.Models
{
    public class TB_RequiredKey
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public int Sort { get; set; }

        public bool IsEnable { get; set; }
    }
}