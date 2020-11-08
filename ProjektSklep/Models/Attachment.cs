using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class Attachment
    {
        /* POLA */
        public int AttatchmentId { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Product Product { get; set; }
    }
}
