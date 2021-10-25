using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        [Range(typeof(double), "0", "10",
            ErrorMessage = "You must enter a rating between numbers 1 - 10...")]
        public double RatingScore { get; set; }

        //Foreign Key for show
        [ForeignKey(nameof(TvShow))]
        public int TvShowId { get; set; }

        public virtual TvShow TvShow { get; set; }

        //Foreign Key for movie
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }


    }
}
