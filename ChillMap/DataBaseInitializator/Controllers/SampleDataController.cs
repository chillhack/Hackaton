using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using ASP.NETCoreWebApplication.DTO;
using ChillMapWeb.Entities;
using ChillMapWeb.Repository;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Application = Application.API.Application;

namespace ASP.NETCoreWebApplication.Controllers
{
    [Route("api/dataBase")]
    public class SampleDataController : Controller
    {
        private const int cityId = 49;
        private const string apiVersion = "5.95";

        [HttpPost("sendUserInfo")]
        public ActionResult SendUserInfo([FromBody] UserInfoDto userInfoDto)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("HackathonDb");
            var placeRepository = new PlaceRepository(database);
            var eventRepository = new EventRepository(database);

            Console.WriteLine(userInfoDto.Token);
            Console.WriteLine(userInfoDto.UserId);
            var items = VkApiRequester.GetAllEvents(
                $"https://api.vk.com/method/groups.search?q=.&city_id=49&count=100&type=event&user_id={userInfoDto.UserId}&access_token={userInfoDto.Token}&v={apiVersion}");
            var result = VkApiRequester.GetEventsDetails(
                $"https://api.vk.com/method/groups.getById?group_ids={string.Join(',', items.Select(i => i.Id))}&fields=place,description,finish_date,name&user_id={userInfoDto.UserId}&access_token={userInfoDto.Token}&v={apiVersion}");

            foreach (var item in result)
            {
                Console.WriteLine(0);
                eventRepository.Create(new Event()
                {
                    Description = item.Description,
                    Id = Guid.NewGuid(),
                    Name = item.Name,
                    Date = new DateTime(item.FinishDate) //TimeSpan.FromSeconds(item.FinishDate)
                });
                if (item.Place == null) continue;
                Console.WriteLine(1);
                placeRepository.Create(new ChillMapWeb.Entities.Place()
                {
                    Id = Guid.NewGuid(),
                    Name = item.Place.Title,
                    Address = item.Place.Address
                });
            }

            return Ok();
        }
    }
}