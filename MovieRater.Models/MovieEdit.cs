using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class MovieEdit
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string MaturityRating { get; set; }
        public string Awards { get; set; }
        public string FamilyFriendly { get; set; }
        public string Educational { get; set; }
    }
}
