using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChillMapWeb.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get;  set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }
    }
}