using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreWebApplication.DTO;
using Microsoft.AspNetCore.Mvc;

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
            Console.WriteLine(userInfoDto.Token);
            Console.WriteLine(userInfoDto.UserId);
            var items = VkApiRequester.GetAllEvents($"https://api.vk.com/method/groups.search?q=.&city_id=49&type=event&user_id={userInfoDto.UserId}&access_token={userInfoDto.Token}&v={apiVersion}");
            VkApiRequester.GetEventsDetails($"https://api.vk.com/method/groups.getById?group_ids={string.Join(',', items.Select(i => i.Id))}&fields=place,description,finish_date,name&user_id={userInfoDto.UserId}&access_token={userInfoDto.Token}&v={apiVersion}");
            return Ok();
        }
    }
}