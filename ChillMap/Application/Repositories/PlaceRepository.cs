using System;
using System.Collections.Generic;
using ChillMapWeb.Entities;
using ChillMapWeb.Repositories;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Application.Repositories
{
    public class PlaceRepository : IRepository<Place>
    {
        private readonly IMongoCollection<Place> places;

        public PlaceRepository(IMongoDatabase database)
        {
            places = database.GetCollection<Place>("Places");
        }

        public List<Place> Get()
        {
            return places.Find(place => true).ToList();
        }
        public Place GetById(Guid id)
        {
            return places.Find(place => place.Id == id).FirstOrDefault();
        }

        public Place Create(Place place)
        {
            places.InsertOne(place);

            return place;
        }

        public void Remove(Guid id)
        {
            places.DeleteOne(place => place.Id == id);
        }

        public void Remove(Place place)
        {
            places.DeleteOne(p => p.Id == place.Id);
        }
    }
}