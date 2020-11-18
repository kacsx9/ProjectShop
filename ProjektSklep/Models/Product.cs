using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class Product
    {
        /* POLA */
        [Key]
        public int ProductID { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        [ForeignKey("Expert")]
        public int ExpertID { get; set; }
        public string Name { get; set; }
        public string ProductDescription { get; set; }
        public string Image { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }
        public bool Promotion { get; set; }
        public int VAT { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public bool Visibility { get; set; }
        public int SoldProducts { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Category Category { get; set; }
        public Expert Expert { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }

        /* METODY */
        public bool GenerateHTML()
        {
            return true;
        }
    }
}
