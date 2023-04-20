using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruk
{
    internal class Uczen : Uzytkownik
    {
        public Ocena[] Oceny { get; set; }
        public Uwaga[] Uwagi { get; set; }
        public Uczen(string imie, string nazwisko, string email, string haslo, Ocena[] oceny, Uwaga[] uwagi) : base(imie, nazwisko, email, haslo)
        {
            Oceny = oceny;
            Uwagi = uwagi;
        }
    }
}
