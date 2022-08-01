namespace Knygu_rezervacijos.Models
{
    public class Rezervacija
    {
        public string KnygosIsbn { get; set; }
        public int SkaitytojoPazymejimoId { get; set; }
        public int KnyguKiekis { get; set; }
    }
}
