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
        private readonly string _title;

        public TvShowService(string title)
        {
            _title = title;
        }
            

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
        public IEnumerable<TvShowListItem> GetTvShow()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var list =
                    ctx.TvShows.Where(l => l.Title == _title)
                    .Select(
                        l => new TvShowListItem
                        {
                            Title = l.Title,
                            Genre = l.Genre,
                            UserRating = l.UserRating,
                            Maturity = l.Maturity,
                        }
                        );
                return list.ToArray();
            }
        }

        //GetbyTitle
        public TvShowListItem GetTvShowByTitle()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var tvtitle = ctx.TvShows.Single(l => l.Title == _title);
                return new TvShowListItem
                {
                    Title = tvtitle.Title,
                    Genre = tvtitle.Genre,
                    UserRating = tvtitle.UserRating,
                    Maturity = tvtitle.Maturity
                };
            }
        }

        //GetbyUserRating


        //Update


        //Delete

    }
}
