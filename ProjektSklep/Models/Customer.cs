using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektSklep.Models
{
    public class Customer
    {
        /* POLA */
        [Key]
        public int CustomerID { get; set; }
        /*[ForeignKey("Address")]
        public int AddressID { get; set; }
        [ForeignKey("PageConfiguration")]
        public int PageConfigurationId { get; set; }*/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool AdminRights { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Address Address { get; set; }
        public PageConfiguration PageConfiguration { get; set; }
        public ICollection<Order> Orders { get; set; }

        /* METODY */
        public bool GenerateNewPassword()
        {
            return true;
        }
    }
}
