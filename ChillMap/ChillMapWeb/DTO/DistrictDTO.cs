using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ChillMapWeb.Entities;
using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class DistrictDTO
    {
        public DistrictDTO(IEnumerable<Place> places, string name)
        {
            Places = places.Select(Mapper.Map<Place, PlaceDTO>);
            Name = name;
        }

        [JsonProperty("places")] public IEnumerable<PlaceDTO> Places{ get; }
        [JsonProperty("name")] public string Name { get; }
    }
}