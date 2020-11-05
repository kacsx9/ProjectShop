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
        //pola
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public List<Product> OrderList { get; set; }
        public int ShippingMethodID { get; set; }
        public int PaymentMethod { get; set; }
        public State OrderStatus { get; set; }

        //metody
        public bool SendOrderStatement()
        {
            return true;
        }
    }
}
