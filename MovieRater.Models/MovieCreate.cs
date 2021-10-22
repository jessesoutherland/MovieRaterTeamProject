using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    class MovieCreate
    {
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
    }
}
