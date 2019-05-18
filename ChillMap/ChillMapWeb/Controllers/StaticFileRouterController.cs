using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{

    [Route("staticFiles")]
    public class StaticFileRouterController : Controller
    {
        [HttpGet("images/{mapId}")]
        public IEnumerable<MapObjectDTO> GetImages()
        {
            throw new NotImplementedException();
        }
    }
}