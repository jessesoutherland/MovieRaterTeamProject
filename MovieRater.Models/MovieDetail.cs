using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class MovieDetail
    {
        [Key]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string MaturityRating { get; set; }
        public string Awards { get; set; }
        [Required]
        public string FamilyFriendly { get; set; }
        [Required]
        public string Educational { get; set; }
        //[Required, Range(0.0, 10.0)]
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
