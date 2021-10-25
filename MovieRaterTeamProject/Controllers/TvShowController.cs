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
    [Authorize]
    public class TvShowController : ApiController
    {
        private readonly string title;

        public IHttpActionResult Get()
        {
            TvShowService tvShowService = CreateTvShowService();
            var tvshows = tvShowService.GetTvShow();
            return Ok(tvshows);
        }

        public IHttpActionResult Post(TvShowCreate tvshow)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTvShowService();

            if (!service.CreateTvShow(tvshow))
                return InternalServerError();

            return Ok();
        }

        private TvShowService CreateTvShowService()
        {
            
            var tvShowService = new TvShowService(title);
            return tvShowService;
        }

        public IHttpActionResult Get(string title)
        {
            TvShowService tvShowService = CreateTvShowService();
            var tvshow = tvShowService.GetTvShowByTitle();
            return Ok(tvshow);
        }

        public IHttpActionResult Put (TvShowEdit tvshow)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTvShowService();

            if (!service.UpdateTvShow(tvshow))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(string title)
        {
            var service = CreateTvShowService();

            if (!service.DeleteTvShow(title))
                return InternalServerError();

            return Ok();
        }
    }
}
