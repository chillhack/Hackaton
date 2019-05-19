using System;
using System.Collections.Generic;
using ChillMapWeb.Entities;
using ChillMapWeb.Repositories;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ChillMapWeb.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly IMongoCollection<User> users;

        public UserRepository(IMongoDatabase database)
        {
            users = database.GetCollection<User>("Users");
        }
        public List<User> Get()
        {
            return users.Find(user => true).ToList();
        }

        public User GetById(Guid userId)
        {
            return users.Find<User>(book => book.Id == userId).FirstOrDefault();
        }

        public User Create(User user)
        {
            users.InsertOne(user);

            return user;
        }

        public void Remove(User user)
        {
            users.DeleteOne(book => book.Id == user.Id);
        }

        public void Remove(Guid id)
        {
            users.DeleteOne(book => book.Id == id);
        }
    }
}