using System;
using System.Collections.Generic;
using Application.Entities;

namespace ChillMapWeb.Repositories
{
    public class MapObjectsRepository : IRepository<MapObjectEntity>
    {
        public List<MapObjectEntity> Get()
        {
            throw new System.NotImplementedException();
        }

        public MapObjectEntity GetById(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(MapObjectEntity elem)
        {
            throw new System.NotImplementedException();
        }

        public MapObjectEntity Create(MapObjectEntity elem)
        {
            throw new System.NotImplementedException();
        }
    }
}