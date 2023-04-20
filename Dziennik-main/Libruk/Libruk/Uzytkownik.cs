using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruk
{
    public class Uzytkownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        private string haslo;

        public Uzytkownik(string imie, string nazwisko, string email, string haslo)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            this.haslo = haslo;
        }

        public bool SprawdzHaslo(string podaneHaslo)
        {
            return haslo == podaneHaslo;
        }
    }
}
