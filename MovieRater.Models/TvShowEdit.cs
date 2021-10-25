using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class TvShowEdit
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int UserRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public bool IsEducational { get; set; }
    }
}
