using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class ProductOrder
    {
        /* POLA */
        [Key]
        public int ProductOrderID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
