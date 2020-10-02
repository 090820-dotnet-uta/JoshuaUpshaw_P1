using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlaughtoriaGamesP1.Models;
using SlaughtoriaGamesP1.Data;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;
using System.Media;
using System.IO.Compression;

namespace SlaughtoriaGamesP1.Models
{
    public class OrderInformation
    {
        
        //Order product info
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public bool IsInBundle { get; set; }
        public bool IsBundle { get; set; }
        public int BundleId { get; set; }

        //Order specific info 
        public int OrderId { get; set; } = 1;
        public int OrderedProduct { get; set; }
        public int? StoreOrderedFrom { get; set; }
        public int WhoOrdered { get; set; }
        public int OrderedProductAmount { get; set; } = 1;
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }

    }
}
