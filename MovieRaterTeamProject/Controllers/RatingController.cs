﻿using MovieRater.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRaterTeamProject.Controllers
{
    public class RatingController : ApiController
    {
        private ApplicationDbContext applicationDbContext = new ApplicationDbContext();
    }
}
