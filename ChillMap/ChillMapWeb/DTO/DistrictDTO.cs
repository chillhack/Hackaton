using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class DistrictDTO
    {
        public DistrictDTO(IEnumerable<PlaceDTO> placeDtos, string name)
        {
            Places= placeDtos;
            Name = name;
        }

        [JsonProperty("places")] public IEnumerable<PlaceDTO> Places{ get; }
        [JsonProperty("name")] public string Name { get; }
    }
}