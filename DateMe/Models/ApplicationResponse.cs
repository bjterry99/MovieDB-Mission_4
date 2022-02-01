using DateMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "What year did the movie release?")]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }

        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [Required]
        public int DirectorID { get; set; }
        public Director Director { get; set; }
    }
}
