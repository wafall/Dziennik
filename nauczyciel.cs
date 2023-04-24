using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruk
{
    using System;
    using System.Data.SqlClient;

    namespace Libruk
    {
        class Nauczyciel
        {
            private SqlConnection polaczenie;

            public Nauczyciel(SqlConnection polaczenie)
            {
                this.polaczenie = polaczenie;
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

            public void DodajOcene()
            {
                Console.WriteLine("Dodawanie oceny:");
                Console.WriteLine("Podaj przedmiot:");
                string temat = Console.ReadLine();
                Console.WriteLine("Podaj ocenę:");
                int ocena = Convert.ToInt32(Console.ReadLine());

                SqlCommand command = new SqlCommand($"INSERT INTO oceny (temat, ocena) VALUES ('{temat}', {ocena})", polaczenie);
                command.ExecuteNonQuery();
                Console.WriteLine("Dodano ocenę.");
            }

            public void EdytujOcene()
            {
                Console.WriteLine("Edytowanie oceny:");
                Console.WriteLine("Podaj ID oceny:");
                int ocenaID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj nową ocenę:");
                int nowaOcena = Convert.ToInt32(Console.ReadLine());

                SqlCommand command = new SqlCommand($"UPDATE oceny SET ocena = {nowaOcena} WHERE Id = {ocenaID}", polaczenie);
                command.ExecuteNonQuery();
                Console.WriteLine("Zaktualizowano ocenę.");
            }

            public void UsunOcene()
            {
                Console.WriteLine("Usuwanie oceny:");
                Console.WriteLine("Podaj ID oceny:");
                int ocenaID = Convert.ToInt32(Console.ReadLine());

                SqlCommand command = new SqlCommand($"DELETE FROM oceny WHERE Id = {ocenaID}", polaczenie);
                command.ExecuteNonQuery();
                Console.WriteLine("Usunięto ocenę.");
            }
        }
    }

}
