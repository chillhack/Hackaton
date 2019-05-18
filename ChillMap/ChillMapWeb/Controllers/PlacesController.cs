using System;
using System.Collections.Generic;
using Application.API;
using Application.Repositories;
using ChillMapWeb.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{
    [ApiController]
    [Route("api/places")]
    public class PlacesController : ControllerBase
    {
        private readonly PlacesAPI api;

        public PlacesController(PlacesAPI api)
        {
            this.api = api;
        }

        [HttpGet("places")]
        public ActionResult<List<Place>> Get()
        {
            return Ok(api.GetAllPlaces());
        }

        [HttpGet("getPlace/{placeId}")]
        public ActionResult<Place> GetPlace(string placeId)
        {
            return Ok(api.GetPlace(placeId));
        }
    }
}