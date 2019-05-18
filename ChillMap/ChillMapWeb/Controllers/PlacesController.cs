using System;
using System.Collections.Generic;
using Application.Repositories;
using ChillMapWeb.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{
    [Route("api/places")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly PlaceRepository repo;

        public PlacesController(PlaceRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Place>> Get()
        {
            return repo.Get();
        }

        [HttpPost]
        public ActionResult<Place> Create(Place place)
        {
            repo.Create(place);

            return CreatedAtRoute("GetPlace", new { id = place.Id.ToString()}, place);
        }
    }
}