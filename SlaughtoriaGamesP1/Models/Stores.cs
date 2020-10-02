using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SlaughtoriaGamesP1.Models
{
    public class Stores
    {
        public Stores()
        {
            Inventory = new HashSet<Inventory>();
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int StoreId { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public int Zip { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
