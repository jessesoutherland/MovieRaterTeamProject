using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class TvShowService
    {

        //Create
        public bool CreateTvShow(TvShowCreate show)
        {
            var entity =
                new TvShow()
                {
                    Title = show.Title,
                    Genre = show.Genre,
                    Episodes = show.Episodes,
                    Seasons = show.Seasons,
                    Maturity = show.Maturity,
                    Awards = show.Awards,
                    OriginalAirDate = show.OriginalAirDate,
                    Description = show.Description,
                    UserRating = show.UserRating
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.TvShows.Add(entity);
                return ctx.SaveChanges() == 1;
            }


        }

        //GetAll

        //GetbyTitle

        //GetbyUserRating


        //Update


        //Delete

    }
}
