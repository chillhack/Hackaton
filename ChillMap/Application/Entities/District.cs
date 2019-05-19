using System;
using System.Collections.Generic;
using ChillMapWeb.Entities;
using ChillMapWeb.Repositories;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Application.Entities
{
    public class District
    {
        public District(Guid id, List<Place> places, string name)
        {
            Id = id;
            Places = places;
            Name = name;
        }

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }

        [BsonElement]
        public List<Place> Places { get; set; }

        [BsonElement]
        public string Name { get; set; }
    }
}