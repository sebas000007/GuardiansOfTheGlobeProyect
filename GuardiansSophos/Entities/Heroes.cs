using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GuardiansSophos.DTO;

namespace GuardiansSophos.Entities
{
    public class Heroes
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public List<Habbilities> Habbilities { get; set; }
        public List<Weaknesses> Weaknesses { get; set; }
        public List<DiaryDTO> Diaries { get; set; }
        public PatternsDTO Patterns { get; set; }
    }
}
