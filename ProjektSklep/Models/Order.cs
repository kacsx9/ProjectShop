using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        public int OrderID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        [ForeignKey("ShippingMethod")]
        public int ShippingMethodID { get; set; }
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodID { get; set; }
        public State OrderStatus { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Customer Customer { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }

        /* METODY */
        public bool SendOrderStatement()
        {
            return true;
        }
    }
}
