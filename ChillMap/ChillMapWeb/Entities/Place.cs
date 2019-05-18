using System;

namespace ChillMapWeb.Entities
{
    public class Place
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
    }
}