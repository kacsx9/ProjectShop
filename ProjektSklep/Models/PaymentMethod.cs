using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class PaymentMethod
    {
        /* POLA */
        [Key]
        public int PaymentMethodID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public string Name { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Order Order { get; set; }
    }
}
