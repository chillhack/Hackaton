using ChillMapWeb.Repositories;

namespace Application.Entities
{
    public class DistrictEntity
    {
        public DistrictEntity(string id, MapObjectsRepository mapObjectsRepository, string name)
        {
            Id = id;
            MapObjectsRepository = mapObjectsRepository;
            Name = name;
        }

        public string Id { get; }
        public MapObjectsRepository MapObjectsRepository { get; }
        public string Name { get; }
    }
}