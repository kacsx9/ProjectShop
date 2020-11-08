using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class Category
    {
        /* POLA */
        public int CategoryID { get; set; }
        public int ParentCategoryID { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public ICollection<Product> Products { get; set; }
        public Category ParentCategory { get; set; }

        /* METODY */
        public bool GenerateProductPriceList()
        {
            return true;
        }
    }
}
