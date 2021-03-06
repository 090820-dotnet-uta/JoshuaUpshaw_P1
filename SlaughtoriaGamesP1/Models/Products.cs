﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SlaughtoriaGamesP1.Models
{
    public class Products
    {
        public Products()
        {
            Inventory = new HashSet<Inventory>();
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int Skunum { get; set; }
        public string ProductName { get; set; }
        public string ProductDescrip { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public bool IsInBundle { get; set; }
        public bool IsBundle { get; set; }
        public int BundleId { get; set; }

        public Products(decimal unitprince, decimal discount)
        {
            Skunum = 90;
            ProductName = "thing";
            ProductDescrip = "thing thing";
            UnitPrice = unitprince;
            ProductDiscount = discount;

        }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
