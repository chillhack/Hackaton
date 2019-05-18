using System.Collections.Generic;
using ChillMapWeb.Entities;
using ChillMapWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventRepository repo;

        public EventsController(EventRepository userRepository)
        {
            repo = userRepository;
        }

        [HttpGet]
        public ActionResult<List<Event>> Get()
        {
            return repo.Get();
        }

        [HttpPost]
        public ActionResult<Event> Create(Event event_)
        {
            repo.Create(event_);

            return CreatedAtRoute("GetEvent", new { id = event_.Id.ToString() }, event_);
        }
    }
}