namespace Application.Entities
{
    public class MapObjectEntity
    {
        public MapObjectEntity(string resourcePath, string xPercents, string yPercents, string id)
        {
            ResourcePath = resourcePath;
            XPercents = xPercents;
            YPercents = yPercents;
            Id = id;
        }

        public string Id { get; }
        public string ResourcePath { get; }
        public string XPercents { get; }
        public string YPercents { get; }
    }
}