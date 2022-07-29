namespace Knygu_rezervacijos.Models
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public string Santrauka { get; set; }
        public string ISBN { get; set; }
        public string Nuotrauka { get; set; }
        public int Puslapiu_skaicius { get; set; }
        public int Kiekis { get; set; }
    }
}
