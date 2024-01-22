using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GuardiansSophos.Entities
{
    public class Habbilities
    {
        public int IdHabbility { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
