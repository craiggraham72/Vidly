using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Movie Name.")]
        [StringLength(255)]
        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Display(Name = "Release Date:")]
        [Required(ErrorMessage = "Please enter Release Date.")]
        public DateTime ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }


        [Range(1,20,ErrorMessage = "The amount must be between 1 and 20.")]
        [Display(Name = "Number In Stock:")]
        [Required(ErrorMessage = "Please enter amount in stock.")]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre:")]
        [Required]
        public byte GenreId { get; set; }


    }
}