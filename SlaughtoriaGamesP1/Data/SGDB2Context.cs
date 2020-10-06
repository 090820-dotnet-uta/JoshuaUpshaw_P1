using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using SlaughtoriaGamesP1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SlaughtoriaGamesP1.Data
{
    public class SGDB2Context : DbContext
    {
        public SGDB2Context(DbContextOptions<SGDB2Context> options) : base(options)
        {

        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Products> Products{ get;set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<SlaughtoriaGamesP1.Models.InventoryProductInfo> InventoryProductInfo { get; set; }
    }
}
