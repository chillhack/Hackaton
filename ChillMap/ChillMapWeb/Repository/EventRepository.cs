using System.Collections.Generic;
using ChillMapWeb.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ChillMapWeb.Repository
{
    public class EventRepository : IRepository<Event>
    {
        private readonly IMongoCollection<Event> events;

        public EventRepository(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("HackathonDb"));
            var database = client.GetDatabase("HackathonDb");
            events = database.GetCollection<Event>("Events");
        }
        public List<Event> Get()
        {
            return events.Find(event_ => true).ToList();
        }
        public Event GetById(string id)
        {
            return events.Find(event_ => event_.Id == id).FirstOrDefault();
        }

        public Event Create(Event event_)
        {
            events.InsertOne(event_);

            return event_;
        }

        public void Remove(string id)
        {
            events.DeleteOne(event_ => event_.Id == id);
        }

        public void Remove(Event elem)
        {
            events.DeleteOne(event_ => event_.Id == elem.Id);
        }
    }
}