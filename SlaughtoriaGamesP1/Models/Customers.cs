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

        [Required(ErrorMessage = "Invalid entry")]
        [StringLength(40, MinimumLength =1, ErrorMessage ="Invalid length")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Invalid entry")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Invalid length")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Invalid entry")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Invalid length")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Invalid entry")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Invalid length")]
        public string Pword { get; set; }

        [Required(ErrorMessage = "Invalid entry")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Invalid length")]
        public string City { get; set; }

        [Required(ErrorMessage = "Invalid entry")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Invalid length")]
        public string State { get; set; }

        [Required(ErrorMessage = "Invalid entry")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Invalid length")]
        public string Street { get; set; }
        public decimal Zip { get; set; }
        public string AptNum { get; set; } = null;
        public int DefaultStore { get; set; } = 1;
    }
}
