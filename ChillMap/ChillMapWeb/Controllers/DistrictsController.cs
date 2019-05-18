using System.Collections.Generic;
using Application.Entities;
using ChillMapWeb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ChillMapWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly DistrictRepository repo;

        public DistrictsController(DistrictRepository districtRepository)
        {
            repo = districtRepository;
        }

        [HttpGet]
        public ActionResult<List<DistrictEntity>> Get()
        {
            return repo.Get();
        }

        [HttpPost]
        public ActionResult<DistrictEntity> Create(DistrictEntity district)
        {
            repo.Create(district);

            return district;
        }
    }
}