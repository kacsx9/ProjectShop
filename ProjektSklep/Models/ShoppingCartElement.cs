using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class ShoppingCartElement
    {
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
