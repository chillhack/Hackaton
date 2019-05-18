using System;

namespace ChillMapWeb.Entities
{
    public class Event
    {
        public Guid Id { get; private set; }
        public Place Location { get; private set; }
    }
}