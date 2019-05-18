using System;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{

    [Route("api/events")]
    [ApiController]
    public class ApplicationController: Controller
    {

        [HttpGet("district{districtId}")]
        public ActionResult<DistrictDTO> GetDistrict(Guid districtId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("place{placeId}")]
        public ActionResult<PlaceDTO> GetPlace(Guid placeId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("event{eventId}")]
        public EventDTO GetEvent(Guid eventId)
        {
            throw new NotImplementedException();
        }
    }
}