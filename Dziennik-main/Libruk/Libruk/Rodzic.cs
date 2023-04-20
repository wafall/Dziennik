using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruk
{
    internal class Rodzic : Uzytkownik
    {
        public int Uczen { get; set; }
        public Rodzic(string imie, string nazwisko, string email, string haslo, int uczen) : base(imie, nazwisko, email, haslo)
        {
            Uczen = uczen;
        }
    }
}
