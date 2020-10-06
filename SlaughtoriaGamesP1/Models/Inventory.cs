using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int ProductCurrentQuantity { get; set; }

        [ForeignKey("ItemInInventory")]
        public virtual Products ItemInInventoryNavigation { get; set; }

        [ForeignKey("StoreInventory")]
        public virtual Stores StoreInventoryNavigation { get; set; }
    }
}
