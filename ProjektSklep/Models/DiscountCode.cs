using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class DiscountCode
    {
        public int DiscountCodeId { get; set; }

        public string DiscoundCode { get; set; }

        public int Percent { get; set; }
    }
}
