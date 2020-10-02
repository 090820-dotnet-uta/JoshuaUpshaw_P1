using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SlaughtoriaGamesP1.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        public int StoreInventory { get; set; }
        public int ItemInInventory { get; set; }
        public int? ProductCurrentQuantity { get; set; }

        public virtual Products ItemInInventoryNavigation { get; set; }
        public virtual Stores StoreInventoryNavigation { get; set; }
    }
}
