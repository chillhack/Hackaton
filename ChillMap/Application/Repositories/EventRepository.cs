using System;
using System.Collections.Generic;
using ChillMapWeb.Entities;
using ChillMapWeb.Repositories;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ChillMapWeb.Repository
{
    public class EventRepository : IRepository<Event>
    {
        private readonly IMongoCollection<Event> events;

        public EventRepository(IMongoDatabase database)
        {
            events = database.GetCollection<Event>("Events");
        }
        public List<Event> Get()
        {
            return events.Find(event_ => true).ToList();
        }
        public Event GetById(Guid id)
        {
            return events.Find(event_ => event_.Id == id).FirstOrDefault();
        }

        public Event Create(Event event_)
        {
            events.InsertOne(event_);

            return event_;
        }

        public void Remove(Guid id)
        {
            events.DeleteOne(event_ => event_.Id == id);
        }

        public void Remove(Event elem)
        {
            events.DeleteOne(event_ => event_.Id == elem.Id);
        }
    }
}