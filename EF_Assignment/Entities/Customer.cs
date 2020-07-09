using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Assignment.Entities
{
    public class Customer
    {
        [Key]
        public int cID { get; set; }

        [Required]
        [MaxLength(30)]
        public string cName { get; set; }

        [Required]
        public string email { get; set; }

        public string? mobileNum{ get; set; }

        [Required]
        public string city { get; set; }
    }
}
