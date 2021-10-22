using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class MovieService
    {
        public bool CreateMovie(MovieCreate model)
        {
            var movie = new Movie()
            {
                Title = model.Title,
                Genre = model.Genre,
                Description = model.Description,
                ReleaseDate = model.ReleaseDate,
                MaturityRating = model.MaturityRating,
                Awards = model.Awards,
                FamilyFriendly = model.FamilyFriendly,
                Educational = model.Educational
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Movies.Add(movie);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<MovieList> GetAllMovies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Movies
                        .Select(
                            e =>
                                new MovieList
                                {
                                    Title = e.Title,
                                    MaturityRating = e.MaturityRating,
                                    ReleaseDate = e.ReleaseDate
                                }
                        );
                return query.ToArray();
            }
        }
        public MovieDetail GetMovieByTitle(string title)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Movies
                        .Single(e => e.Title == title);
                return
                    new MovieDetail
                    {
                        Title = entity.Title,
                        Genre = entity.Genre,
                        Description = entity.Description,
                        ReleaseDate = entity.ReleaseDate,
                        MaturityRating = entity.MaturityRating,
                        Awards = entity.Awards,
                        FamilyFriendly = entity.FamilyFriendly,
                        Educational = entity.Educational,
                    };
            }
        }
        public MovieDetail GetMovieByGenre(string genre)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Movies
                        .Single(e => e.Genre == genre);
                return
                    new MovieDetail
                    {
                        Title = entity.Title,
                        Genre = entity.Genre,
                        Description = entity.Description,
                        ReleaseDate = entity.ReleaseDate,
                        MaturityRating = entity.MaturityRating,
                        Awards = entity.Awards,
                        FamilyFriendly = entity.FamilyFriendly,
                        Educational = entity.Educational,
                    };
            }
        }
        public bool UpdateMovie(MovieEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Movies
                        .Single(e => e.Title == model.Title);

                entity.Title = model.Title;
                entity.Genre = model.Genre;
                entity.Description = model.Description;
                entity.ReleaseDate = model.ReleaseDate;
                entity.MaturityRating = model.MaturityRating;
                entity.Awards = model.Awards;
                entity.FamilyFriendly = model.FamilyFriendly;
                entity.Educational = model.Educational;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteMovie(string title)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Movies
                        .Single(e => e.Title == title);

                ctx.Movies.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
