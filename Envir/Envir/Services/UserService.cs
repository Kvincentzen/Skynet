using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Envir.Models;
using MongoDB.Driver;

namespace Envir.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("UserCS"));
            var database = client.GetDatabase("Skynet");

            _users = database.GetCollection<User>("SkynetData");
        }
        /// Get method for alle brugere
        public List<User> Get() => _users.Find(user => true).ToList();

        public User Get(string id) => _users.Find<User>(user => user.Id == id).FirstOrDefault();

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(string id, User userUp) => _users.ReplaceOne(user => user.Id == id, userUp);

        public void Remove(User userUp) => _users.DeleteOne(user => user.Id == userUp.Id);
    }
}
