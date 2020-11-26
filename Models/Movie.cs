using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter the Movie Name")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage ="Please specify a Genre")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage ="Please Enter the Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,50,ErrorMessage ="Please Enter a value between 1 to 50")]
        [Required(ErrorMessage ="Please Enter the Stock")]
        public byte NumberInStock { get; set; }
    }
}