using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Director
    {
        [Key]
        [Required]
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
    }
}
