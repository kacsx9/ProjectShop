using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class Address
    {
        /* POLA */
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Customer Customer { get; set; }
    }
}
