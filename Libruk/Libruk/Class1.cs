using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruk
{
        public class Uczen
        {
            private readonly SqlConnection polaczenie;

            public Uczen(SqlConnection polaczenie)
            {
                polaczenie = polaczenie;
            }

        public void WyswietlOceny()
        {
            Console.WriteLine("Wyświetlanie ocen:");

            SqlCommand command = new SqlCommand("SELECT * FROM oceny", polaczenie);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["temat"]} - {reader["ocena"]}");
            }

            reader.Close();
        }
        public void WyswietlUwagi()
            {
                // Kod wyświetlający uwagi dla danego ucznia
                Console.WriteLine("Wyświetlanie uwag...");
            }
        }
    }


