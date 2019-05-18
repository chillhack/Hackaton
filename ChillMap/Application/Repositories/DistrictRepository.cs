using System;
using System.Collections.Generic;
using Application.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ChillMapWeb.Repositories
{
    public class DistrictRepository: IRepository<DistrictEntity>
    {
        private readonly IMongoCollection<DistrictEntity> districts;

        public DistrictRepository(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("HackathonDb"));
            var database = client.GetDatabase("HackathonDb");
            districts = database.GetCollection<DistrictEntity>("Districts");
        }

        public List<DistrictEntity> Get()
        {
            return districts.Find(district => true).ToList();
        }

        public DistrictEntity GetById(Guid id)
        {
            return districts.Find(district => district.Id == id).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            districts.DeleteOne(district => district.Id == id);
        }

        public void Remove(DistrictEntity elem)
        {
            districts.DeleteOne(district => district.Id == elem.Id);
        }

        public DistrictEntity Create(DistrictEntity elem)
        {
            districts.InsertOne(elem);

            return elem;
        }
    }
}