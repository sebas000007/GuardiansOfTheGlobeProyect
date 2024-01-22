using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GuardiansSophos.Entities
{
    public class Villain
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Origen { get; set; }
        public string Power { get; set; }
        public List<Habbilities> Habbilities { get; set; }
        public List<Weaknesses> Weaknesses { get; set; }
    }
}
