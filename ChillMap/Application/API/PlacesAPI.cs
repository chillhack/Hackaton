using System.Collections.Generic;
using Application.Repositories;
using ChillMapWeb.Entities;

namespace Application.API
{
    public class PlacesAPI
    {
        private readonly PlaceRepository placeRepository;

        public PlacesAPI(PlaceRepository placeRepository)
        {
            this.placeRepository = placeRepository;
        }

        public List<Place> GetAllPlaces()
        {
            throw new System.NotImplementedException();
        }

        public Place GetPlace(string placeId)
        {
            throw new System.NotImplementedException();
        }
    }
}