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
        private decimal _cartPrice;
        public decimal CartPrice
        {
            get
            {
                decimal sum = 0M;
                foreach (var product in ProductList)
                {
                    sum += product.Sum;
                }
                return sum;

            } set
            {
                _cartPrice = value;
            }

        }

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
