using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class TvShowListItem
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int UserRating { get; set; }
        public int Maturity { get; set; }
    }
}
