using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        //public List<Order> OrderList { get; set; }
        public int ConfigurationId { get; set; }
        public bool AdminRights { get; set; }

        public bool GenerateNewPassword()
        {
            return true;
        }
    }
}
