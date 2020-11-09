using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class ProductOrder
    {
        /* POLA */
        [Key]
        public int ProductOrderID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
