using System;
using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class MapObjectDTO
    {
        public MapObjectDTO(string resourcePath, string name, Guid id, string position)
        {
            ResourcePath = resourcePath;
            Name = name;
            Id = id;
            Position = position;
        }

        [JsonProperty("path")] public string ResourcePath { get; }
        [JsonProperty("name")] public string Name { get; }
        [JsonProperty("id")] public Guid Id { get; }
        [JsonProperty("position")] public string Position { get; }
    }
}