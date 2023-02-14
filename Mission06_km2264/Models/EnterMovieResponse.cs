using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_km2264.Models
{
    public class EnterMovieResponse
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category is a required field")] // validation
        public string Category { get; set; }
        [Required(ErrorMessage = "title is a required field")] // validation
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is a required field")] // validation
        public short Year { get; set; }
        [Required(ErrorMessage = "Director is a required field")] // validation
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating is a required field")] // validation
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent {get; set;}
        [StringLength(25)] // validation
        public string Notes { get; set; }
    }
}
