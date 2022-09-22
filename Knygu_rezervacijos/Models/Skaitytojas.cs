using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Knygu_rezervacijos.Models
{
    public class Skaitytojas
    {
        public Skaitytojas()
        {
            this.Rezervacijos = new HashSet<Rezervacija>();
            this.Megstamiausios = new HashSet<Knyga>();
        }
        [Key]
        public int PazymejimoId { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime PazymejimoIsdavimoData { get; set; }
        public string Slaptazodis { get; set; }
        [NotMapped]
        public string PakartotiSlaptazodi { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijos { get; set; }
        public virtual ICollection<Knyga> Megstamiausios { get; set; }
    }
}
