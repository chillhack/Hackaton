using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChillMapWeb.Entities
{
    public class Event
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        // TODO: заменить string на Place
        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string Description { get; set; }

        [BsonElement]
        public string Location { get; set; }

        // public string Owner??

        [BsonDateTimeOptions(Kind=DateTimeKind.Local)]
        public DateTime Date { get; set; }
    }
}