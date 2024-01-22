using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GuardiansSophos.Entities
{
    public class Weaknesses
    {
        public int IdWeakness { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
