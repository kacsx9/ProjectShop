using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class Category
    {
        //pola
        public int CategoryID { get; set; }
        public int ParentCategoryID { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }

        //metody
        public bool GenerateProductPriceList()
        {
            return true;
        }
    }
}
