using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public enum State
    {
        Preparing = 0,
        OnTheWay = 1,
        Delivered = 2
    }

    public class Order
    {
        /* POLA */
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int ShippingMethodId { get; set; }
        public int PaymentMethodId { get; set; }
        public State OrderStatus { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        /* METODY */
        public bool SendOrderStatement()
        {
            return true;
        }
    }
}
