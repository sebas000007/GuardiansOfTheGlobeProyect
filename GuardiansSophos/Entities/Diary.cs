using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GuardiansSophos.Entities
{
    public class Diary
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime InitHour { get; set; }
        public DateTime EndHour { get; set; }
        public string NameActivity {  get; set; }
        public string Description {  get; set; }
    }
}
