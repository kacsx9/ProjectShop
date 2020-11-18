﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Models
{
    public class ShippingMethod
    {
        /* POLA */
        [Key]
        public int ShippingMethodID { get; set; }
        public string Name { get; set; }

        /* POLA - ENTITY FRAMEWORK */
        public ICollection<Order> Orders { get; set; }
    }
}
