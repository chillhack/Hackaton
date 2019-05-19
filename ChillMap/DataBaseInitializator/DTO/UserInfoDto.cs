using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ASP.NETCoreWebApplication.DTO
{
    public class UserInfoDto
    {
        public UserInfoDto(string token, int userId)
        {
            Token = token;
            UserId = userId;
        }

        [JsonProperty("token")] public string Token { get; }
        [JsonProperty("userId")] public int UserId { get; }
    }
}