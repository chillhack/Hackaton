using System;
using System.Collections.Generic;
using Application.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChillMapWeb.Entities
{
    public class Place
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }

        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string Description { get; set; }

        [BsonElement]
        public string Address { get; set; }

        [BsonElement]
        public string PhoneNumber { get; set; }

        [BsonElement]
        public List<Event> Events { get; set; }

        [BsonElement]
        public Position Position { get; set; }

        [BsonElement]
        public string Path { get; set; }
    }
}