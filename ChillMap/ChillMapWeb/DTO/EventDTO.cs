using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChillMapWeb.Controllers
{
    public class EventDTO
    {
        public EventDTO(string name, string description, DateTime date, string path)
        {
            Name = name;
            Description = description;
            Date = date;
            Path = path;
        }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("description")]
        public string Description { get; }

        [JsonProperty("date")]
        public DateTime Date { get; }
        
        [JsonProperty("path")]
        public string Path { get; }
    }
}