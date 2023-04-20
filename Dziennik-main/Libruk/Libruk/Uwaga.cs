namespace Libruk
{
    public class Uwaga
    {
        public string Tresc { get; set; }
        public string DataUzyskania { get; set; }
        public int NauczycielId { get; set; }
        public bool RodzajUwagi { get; set; }
        public string Kategoria { get; set; }

        public Uwaga(string tresc, string dataUzyskania, int nauczycielId, bool rodzajUwagi, string kategoria)
        {
            Tresc = tresc;
            DataUzyskania = dataUzyskania;
            NauczycielId = nauczycielId;
            RodzajUwagi = rodzajUwagi;
            Kategoria = kategoria;
        }
    }

}
