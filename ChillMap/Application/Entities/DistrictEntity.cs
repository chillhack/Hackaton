using System.Collections.Generic;
using ChillMapWeb.Repositories;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Application.Entities
{
    public class DistrictEntity
    {
        public DistrictEntity(string id, List<MapObjectEntity> mapObjects, string name)
        {
            Id = id;
            MapObjects = mapObjects;
            Name = name;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement]
        public List<MapObjectEntity> MapObjects { get; set; }

        [BsonElement]
        public string Name { get; set; }
    }
}