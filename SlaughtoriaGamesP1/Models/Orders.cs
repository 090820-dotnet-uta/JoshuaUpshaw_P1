using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SlaughtoriaGamesP1.Models
{
    public class Orders
    {
        [Key]
        public int Pk { get; set; }
        public int OrderId { get; set; }
        public int OrderedProduct { get; set; }
        public int? StoreOrderedFrom { get; set; }
        public int WhoOrdered { get; set; }
        public int OrderedProductAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }

        [ForeignKey("OrderedProduct")]
        public virtual Products OrderedProductNavigation { get; set; }

        [ForeignKey("StoreOrderedFrom")]
        public virtual Stores StoreOrderedFromNavigation { get; set; }

        [ForeignKey("WhoOrdered")]
        public virtual Customers WhoOrderedNavigation { get; set; }
    }
}
