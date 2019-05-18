using System;

namespace ChillMapWeb.Entities
{
    public class Event
    {
        public Guid Id { get; private set; }
        public Place Location { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
    }
}