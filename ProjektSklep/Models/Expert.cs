using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Expert
    {
        /* POLA */
        [Key]
        public int ExpertId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public ICollection<Product> Products { get; set; }
    }
}
