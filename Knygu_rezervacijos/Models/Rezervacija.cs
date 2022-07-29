namespace Knygu_rezervacijos.Models
{
    public class Rezervacija
    {
        public string Knygos_isbn { get; set; }
        public int Skaitytojo_pazymejimo_id { get; set; }
        public int Knygu_kiekis { get; set; }
    }
}
