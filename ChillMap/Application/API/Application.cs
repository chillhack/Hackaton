using System;
using System.Collections.Generic;
using Application.Entities;
using Application.Repositories;
using ChillMapWeb.Entities;
using ChillMapWeb.Repositories;
using ChillMapWeb.Repository;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Application.API
{
    public class Application
    {
        private readonly EventRepository eventRep;
        private readonly DistrictRepository districtRep;
        private readonly PlaceRepository placeRep;

        public Application(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("HackathonDb"));
            var database = client.GetDatabase("HackathonDb");

            eventRep = new EventRepository(database);
            districtRep = new DistrictRepository(database);
            placeRep = new PlaceRepository(database);
        }

        public District GetDistrict(Guid districtId) => districtRep.GetById(districtId);

        public Place GetPlace(Guid placeId) => placeRep.GetById(placeId);

        public Event GetEvent(Guid eventId)
        {
//            districtRep.Create(new District(
//                Guid.NewGuid(),
//                new List<Place>()
//                {
//                    new Place()
//                    {
//                        Id = Guid.NewGuid(),
//                        Name = "Yeltsin Center",
//                        Description = "Cool place",
//                        Address = "Yeltsina, 1",
//                        Events = new List<Event>
//                        {
//                        },
//                        Path = "C://User/photo.png",
//                        PhoneNumber = "+79920183322",
//                        Position = new Position()
//                        {
//                            X = 45,
//                            Y = 23
//                        }
//                    }
//                },
//                "recovery"
//            ));

            return eventRep.GetById(eventId);
        }
    }
}