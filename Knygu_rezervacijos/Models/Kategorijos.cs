using MessagePack;


namespace Knygu_rezervacijos.Models
{
    public class Kategorijos
    {
        public string Kategorija { get; set; }
        public int KategorijosId { get; set; }
        public ICollection<Knyga> Knyga { get; set; }
    }
}
