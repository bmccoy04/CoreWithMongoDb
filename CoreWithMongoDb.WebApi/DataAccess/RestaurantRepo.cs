using System.Collections.Generic;
using CoreWithMongoDb.WebApi.Models;
using MongoDB.Driver;
//using MongoDB.Driver.Builder;

namespace CoreWithMongoDb.WebApi.DataAccess
{
    public class RestaurantRepo
    {
        IMongoClient _client;
        IMongoDatabase _db;

        public RestaurantRepo(){
            _client = new MongoClient("mongodb://testUser:testUserPassword@192.168.7.100:27017/test");
            _db = _client.GetDatabase("test");
        }

        public IEnumerable<Restaurant> Get(){            
            return _db.GetCollection<Restaurant>("restaurants").Find(_ => true).ToList();
        }
    }
}