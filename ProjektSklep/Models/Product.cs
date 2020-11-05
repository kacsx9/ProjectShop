using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class Product
    {
        //pola
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public string ProductDescription { get; set; }
        public string Image { get; set; }
        public List<int> AttachmentList { get; set; }
        public DateTime DateAdded { get; set; }         //format daty ewentualnie do zmiany
        public bool Promotion { get; set; }
        public int VAT { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public bool Visibility { get; set; }
        public int SoldProducts { get; set; }
        public int ExpertID { get; set; }

        //metody
        public bool GenerateHTML()  //nieskonczone
        {
            return true;
        }
    }
}
