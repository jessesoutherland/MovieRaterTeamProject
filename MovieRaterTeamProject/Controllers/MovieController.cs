using Microsoft.AspNet.Identity;
using MovieRater.Models;
using MovieRater.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRaterTeamProject.Controllers
{
    public class MovieController : ApiController
    {
        private MovieService CreateMovieService()
        {
            var movieService = new MovieService();
            return movieService;
        }
        public IHttpActionResult Post(MovieCreate movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateMovieService();

            if (!service.CreateMovie(movie))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get()
        {
            MovieService movieService = CreateMovieService();
            var movies = movieService.GetAllMovies();
            return Ok(movies);
        }
        public IHttpActionResult GetByTitle(string title)
        {
            MovieService noteService = CreateMovieService();
            var note = noteService.GetMovieByTitle(title);
            return Ok(note);
        }
        public IHttpActionResult GetByGenre(string genre)
        {
            MovieService noteService = CreateMovieService();
            var note = noteService.GetMovieByGenre(genre);
            return Ok(note);
        }
        public IHttpActionResult Put(MovieEdit movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateMovieService();

            if (!service.UpdateMovie(movie))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(string title)
        {
            var service = CreateMovieService();

            if (!service.DeleteMovie(title))
                return InternalServerError();

            return Ok();
        }
    }
}
