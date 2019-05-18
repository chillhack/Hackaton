using System.Collections.Generic;
using ChillMapWeb.Entities;
using ChillMapWeb.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ChillMapWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository repo;

        public UsersController(UserRepository userRepository)
        {
            repo = userRepository;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return repo.Get();
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            repo.Create(user);

            return CreatedAtRoute("GetBook", new { id = user.Id.ToString() }, user);
        }
    }
}