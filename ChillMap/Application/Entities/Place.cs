using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChillMapWeb.Entities
{
    public class Place
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string Address { get; set; }

        [BsonElement]
        public List<Event> Events { get; set; }
    }
}