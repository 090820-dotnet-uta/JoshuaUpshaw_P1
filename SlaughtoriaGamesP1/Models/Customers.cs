using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SlaughtoriaGamesP1.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Pword { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public decimal Zip { get; set; }
        public string AptNum { get; set; } = null;
        public int DefaultStore { get; set; } = 1;
    }
}
