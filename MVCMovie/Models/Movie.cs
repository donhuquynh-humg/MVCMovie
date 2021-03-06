using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]

        public string Genre { get; set; }

        
        public decimal Price { get; set; }
        public string Rating { get; set; }
        public string Email { get; set; }



    }
}


