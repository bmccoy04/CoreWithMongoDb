using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CoreWithMongoDb.WebApi.Models
{
    [BsonIgnoreExtraElements]
    public class Restaurant
    {
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("restaurant_id")]
        public string RestaurantId { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }

        [BsonElement("borough")]
        public string Borough { get; set; }

        [BsonElement("cuisine")]
        public string Cuisine { get; set; }
    }

    public class Address
    {
        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("zipcode")]
        public string Zipcode { get; set; }

        [BsonElement("building")]
        public string Building { get; set; }

        [BsonElement("coord")]
        public decimal[] Coord {get;set;}
    }
}