using System;

namespace ChillMapWeb.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
    }
}