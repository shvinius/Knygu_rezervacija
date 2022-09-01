namespace Knygu_rezervacijos.Models
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public int KnyguKiekis { get; set; }
        public Knyga Knyga { get; set; }
        public Skaitytojas Skaitytojas { get; set; }
    }
}
