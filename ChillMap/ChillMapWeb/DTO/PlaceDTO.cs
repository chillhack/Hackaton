using System.Collections.Generic;
using System.Linq;
using Application.Entities;
using AutoMapper;
using ChillMapWeb.Entities;
using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class PlaceDTO
    {
        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("description")]
        public string Description { get; }

        [JsonProperty("address")]
        public string Address { get; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; }

        [JsonProperty("events")]
        public List<EventDTO> Events { get; }

        [JsonProperty("position")]
        public PositionDTO Position { get; }

        [JsonProperty("path")]
        public string Path { get; }

        public PlaceDTO(string name, string description, string address, string phoneNumber, List<Event> events, Position position, string path)
        {
            Name = name;
            Description = description;
            Address = address;
            PhoneNumber = phoneNumber;
            Events = events.Select(Mapper.Map<Event, EventDTO>).ToList();
            Position = Mapper.Map<Position, PositionDTO>(position);
            Path = path;
        }
    }
}