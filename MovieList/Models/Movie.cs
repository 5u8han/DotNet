using System;
using System.ComponentModel.DataAnnotations;



namespace MovieList.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required(ErrorMessage ="Please enter your name.")]

        public string Name { get; set; }

        
        [Required(ErrorMessage ="Please Enter a Year.")]
        [Range(1889, 2050, ErrorMessage = "Year Must Be Between 1889 and Now.")]
        public int? Year{ get; set; }

        [Required(ErrorMessage ="Please Enter a Rating/")]
        [Range(1,5, ErrorMessage ="Rating must be between 1 and 5.")]
        public int? Rating{ get; set; }
        [Required(ErrorMessage ="Please Enter a Genre.")]
        public string GenreID { get; set; }
        public Genre Genre{ get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();


    }

}
