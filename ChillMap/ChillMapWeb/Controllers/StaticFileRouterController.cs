using System;
using System.Collections.Generic;
using ChillMapWeb.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{

    [Route("staticFiles")]
    public class StaticFileRouterController : Controller
    {
        [HttpGet("images/{mapId}")]
        public IEnumerable<Place> GetImages()
        {
            throw new NotImplementedException();
        }
    }
}