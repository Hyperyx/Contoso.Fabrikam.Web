using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Contoso.Fabrikam.Web.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string MovieName { get; set; }
        
        public int Year { get; set; }
        
        public string Director { get; set; }
    }
}