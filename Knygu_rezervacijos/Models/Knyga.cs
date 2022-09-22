using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;





namespace Knygu_rezervacijos.Models
{
    public class Knyga
    {
        public Knyga()
        {
            this.Skaitytojai = new HashSet<Skaitytojas>();
            this.Rezervacijos = new HashSet<Rezervacija>();
        }
        public int Id { get; set; }
        [StringLength(200, ErrorMessage = "Pavadinimas cannot be longer than 200 characters.")]
        public string Pavadinimas { get; set; }
    
        public string Santrauka { get; set; }
        public string ISBN { get; set; }
        public string Nuotrauka { get; set; }
        public int PuslapiuSkaicius { get; set; }
        public int Kiekis { get; set; }
        public Kategorijos Kategorijos { get; set; }

        public virtual ICollection<Skaitytojas> Skaitytojai { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijos { get; set; }
    }
}
