using MongoDB.Bson.Serialization.Attributes;

namespace Application.Entities
{
    public class Position
    {
        [BsonElement]
        public int X { get; set; }

        [BsonElement]
        public int Y { get; set; }
    }
}