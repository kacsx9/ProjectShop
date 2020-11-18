using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Category
    {
        /* POLA */
        [Key]
        public int CategoryID { get; set; }
        public int? ParentCategoryID { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public Category Parent { get; set; }
        public ICollection<Category> Childern { get; set; }
        public ICollection<Product> Products { get; set; }

        /* METODY */
        public bool GenerateProductPriceList()
        {
            return true;
        }
    }
}
