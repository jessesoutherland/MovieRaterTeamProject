using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class MovieList
    {
        public string Title { get; set; }
        public string MaturityRating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        //public double Rating
        //{
        //    get
        //    {
        //        if (Ratings.Count == 0)
        //        {
        //            return 0;
        //        }
        //        double ratingScore = 0;

        //        foreach (var rating in Ratings)
        //        {
        //            ratingScore += rating.Score;
        //        }

        //        return Math.Round(ratingScore / Ratings.Count, 1);
        //    }
        //}
        //public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
