using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class DistrictDTO
    {
        public DistrictDTO(string id, IEnumerable<MapObjectDTO> mapObjects, string name)
        {
            Id = id;
            MapObjects = mapObjects;
            Name = name;
        }

        [JsonProperty("id")] public string Id { get; }
        [JsonProperty("mapObjects")] public IEnumerable<MapObjectDTO> MapObjects { get; }
        [JsonProperty("name")] public string Name { get; }
    }
}