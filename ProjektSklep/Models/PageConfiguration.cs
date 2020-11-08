using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class PageConfiguration
    {
        /* POLA */
        [Key]
        public int PageConfigurationID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public bool SendingNewsletter { get; set; }
        public bool ShowNetPrices { get; set; }
        public int ProductsPerPage { get; set; }
        public int InterfaceSkin { get; set; }
        public int Language { get; set; }
        public int Currency { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Customer Customer { get; set; }
    }
}
