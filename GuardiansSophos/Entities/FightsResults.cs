
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GuardiansSophos.Entities
{
    public class FightsResults
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string IsWinner {  get; set; } 
        public Heroes Hero {  get; set; }
        public Villain Villain { get; set; }
    }
}
