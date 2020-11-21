using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class ShoppingCart
    {
        /* POLA */
        public List<ShoppingCartElement> ProductList { get; set; }

        /* METODY */

        public bool AddProduct() 
        { 
            return true; 
        }
        public bool DeleteProduct() 
        { 
            return true; 
        }
    }
}
