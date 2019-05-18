using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class DistrictDTO
    {
        public DistrictDTO(IEnumerable<MapObjectDTO> mapObjects, string name)
        {
            MapObjects = mapObjects;
            Name = name;
        }

        [JsonProperty("mapObjects")] public IEnumerable<MapObjectDTO> MapObjects { get; }
        [JsonProperty("name")] public string Name { get; }
    }
}