using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruk
{
    public class Nauczyciel : Uzytkownik
    {
        public Nauczyciel(string imie, string nazwisko, string email, string haslo) : base(imie, nazwisko, email, haslo)
        {
        }
    }

}
