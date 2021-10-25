using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class TvShowCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Please enter at least 2 characters")]
        [MaxLength(50, ErrorMessage ="Too many characters, please shorten detail.")]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }
        public int Episodes { get; set; }
        public int Seasons { get; set; }
        public int Maturity { get; set; }
        public string Awards { get; set; }
        public DateTime OriginalAirDate { get; set; }
        public string Description { get; set; }
        public int UserRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public bool IsEducational { get; set; }
    }
}
