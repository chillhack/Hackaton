using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChillMapWeb.Controllers
{
    public class EventDTO
    {
        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("description")]
        public string Description { get; }

        [JsonProperty("date")]
        public DateTime Date { get; }

        public EventDTO(string name, string description, DateTime date)
        {
            Name = name;
            Description = description;
            Date = date;
        }
    }
}