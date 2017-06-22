using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter Movie Name.")]
        [StringLength(255)]
        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Display(Name = "Release Date:")]
        [Required(ErrorMessage = "Please enter Release Date.")]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20, ErrorMessage = "The amount must be between 1 and 20.")]
        [Display(Name = "Number In Stock:")]
        [Required(ErrorMessage = "Please enter amount in stock.")]
        public int? NumberInStock { get; set; }

        [Display(Name = "Genre:")]
        [Required]
        public byte? GenreId { get; set; }

        public string Title
        {
            get
            {
                if(Id != 0)
                {
                    return "Edit Movie";
                }
                else
                {
                    return "New Movie";
                }
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

    }
}