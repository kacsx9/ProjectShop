using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektSklep.Models
{
    public class Attachment
    {
        /* POLA */
        [Key]
        public int AttachmentID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Product Product { get; set; }
    }
}
