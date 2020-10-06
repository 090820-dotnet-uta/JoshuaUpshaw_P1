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
using System.ComponentModel.DataAnnotations;

namespace SlaughtoriaGamesP1.Models
{
    public class InventoryProductInfo 
    {
        [Key]
        public int Skunum { get; set; }
        public string ProductName { get; set; }
        public string ProductDescrip { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public int? ProductCurrentQuantity { get; set; }
        public bool IsInBundle { get; set; }
        public bool IsBundle { get; set; }
        public int BundleId { get; set; }
        public int OrderedAmt { get; set; } = 1;
    }
}
