using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GuardiansSophos.Entities
{
    public class Patterns
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string OriginAmount { get; set; }
    }
}
