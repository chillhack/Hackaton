using System;
using System.Collections.Generic;
using Application.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ChillMapWeb.Repositories
{
    public class DistrictRepository: IRepository<District>
    {
        private readonly IMongoCollection<District> districts;

        public DistrictRepository(IMongoDatabase database)
        {
            districts = database.GetCollection<District>("Districts");
        }

        public List<District> Get()
        {
            return districts.Find(district => true).ToList();
        }

        public District GetById(Guid id)
        {
            return districts.Find(district => district.Id == id).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            districts.DeleteOne(district => district.Id == id);
        }

        public void Remove(District elem)
        {
            districts.DeleteOne(district => district.Id == elem.Id);
        }

        public District Create(District elem)
        {
            districts.InsertOne(elem);

            return elem;
        }
    }
}