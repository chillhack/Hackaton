using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChillMapWeb.Entities;
using ChillMapWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public ActionResult<string> Index()
        {
            return Ok("Hello, World!");
        }
    }
}