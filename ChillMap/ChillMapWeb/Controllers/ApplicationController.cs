using System;
using Application.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{

    [Route("api/")]
    [ApiController]
    public class ApplicationController: Controller
    {
        private readonly Application.API.Application app;

        public ApplicationController(Application.API.Application app)
        {
            this.app = app;
        }

        [HttpGet("district/{districtId}")]
        public ActionResult<DistrictDTO> GetDistrict(string districtId) => Ok(Mapper.Map<District, DistrictDTO>(app.GetDistrict(new Guid(districtId))));

        [HttpGet("place/{placeId}")]
        public ActionResult<PlaceDTO> GetPlace(string placeId) => Ok(Mapper.Map<PlaceDTO>(app.GetPlace(new Guid(placeId))));

        [HttpGet("event/{eventId}")]
        public ActionResult<EventDTO> GetEvent(string eventId) => Ok(Mapper.Map<EventDTO>(app.GetEvent(new Guid(eventId))));
    }
}