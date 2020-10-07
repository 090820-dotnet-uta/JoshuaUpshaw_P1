using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlaughtoriaGamesP1.Models
{
    public class EditCart
    {
        public int storeId { get; set; }
        public int itemId { get; set; }

        public int OrderNum { get; set; } = 0;

        public IEnumerable<SlaughtoriaGamesP1.Models.OrderInformation> Cart { get; set; }
    }
}
