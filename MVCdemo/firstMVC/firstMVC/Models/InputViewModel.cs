using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstMVC.Models
{
    public class InputViewModel
    {
        public int Skaicius { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }             

        public string LastName { get; set; }
    }
}
