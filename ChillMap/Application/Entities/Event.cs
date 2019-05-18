using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChillMapWeb.Entities
{
    public class Event
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }

        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string Description { get; set; }

        [BsonDateTimeOptions(Kind=DateTimeKind.Local)]
        public DateTime Date { get; set; }
    }
}