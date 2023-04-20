using System;
using System.Data.SqlClient;

namespace Libruk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Połączenie z bazą danych
            string polaczeniezbaza = "Data Source=312-05;Initial Catalog=Librusprogram; Integrated Security=True";
            using (SqlConnection polaczenie = new SqlConnection(polaczeniezbaza))
            {
                polaczenie.Open();

                // Menu wyboru panelu (nauczyciel, uczeń, rodzic)
                Console.WriteLine("Wybierz panel:");
                Console.WriteLine("1. Nauczyciel");
                Console.WriteLine("2. Uczeń/Rodzic");
                int panelwyboru = Convert.ToInt32(Console.ReadLine());

                switch (panelwyboru)
                {
                    case 1:
                        // Panel nauczyciela
                        Console.WriteLine("Panel nauczyciela");

                        // CRUD ocen
                        Console.WriteLine("CRUD ocen:");
                        Console.WriteLine("1. Wyświetl oceny");
                        Console.WriteLine("2. Dodaj ocenę");
                        Console.WriteLine("3. Edytuj ocenę");
                        Console.WriteLine("4. Usuń ocenę");
                        int CRUDocen = Convert.ToInt32(Console.ReadLine());

                        switch (CRUDocen)
                        {
                            case 1:
                                // Wyświetlenie ocen
                                Console.WriteLine("Wyświetlanie ocen:");

                                SqlCommand command = new SqlCommand("SELECT * FROM oceny", polaczenie);
                                SqlDataReader reader = command.ExecuteReader();

                                while (reader.Read())
                                {
                                    Console.WriteLine($"{reader["temat"]} - {reader["ocena"]}");
                                }

                                reader.Close();
                                break;

                            case 2:
                                // Dodanie oceny
                                Console.WriteLine("Dodawanie oceny:");
                                Console.WriteLine("Podaj przedmiot:");
                                string temat = Console.ReadLine();
                                Console.WriteLine("Podaj ocenę:");
                                int ocena = Convert.ToInt32(Console.ReadLine());

                                command = new SqlCommand($"INSERT INTO oceny (temat, ocena) VALUES ('{temat}', {ocena})", polaczenie);
                                command.ExecuteNonQuery();
                                Console.WriteLine("Dodano ocenę.");
                                break;

                            case 3:
                                // Edycja oceny
                                Console.WriteLine("Edytowanie oceny:");
                                Console.WriteLine("Podaj ID oceny:");
                                int ocenaID = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Podaj nową ocenę:");
                                int nowaOcena = Convert.ToInt32(Console.ReadLine());

                                command = new SqlCommand($"UPDATE oceny SET ocena = {nowaOcena} WHERE Id = {ocenaID}", polaczenie);
                                command.ExecuteNonQuery();
                                Console.WriteLine("Zaktualizowano ocenę.");
                                break;

                            case 4:
                                // Usunięcie oceny
                                Console.WriteLine("Usuwanie oceny:");
                                Console.WriteLine("Podaj ID oceny:");
                                ocenaID = Convert.ToInt32(Console.ReadLine());

                                command = new SqlCommand($"DELETE FROM oceny WHERE Id = {ocenaID}", polaczenie);
                                command.ExecuteNonQuery();
                                Console.WriteLine("Usunięto ocenę.");
                                break;

                            default:
                                Console.WriteLine("Nieprawidłowy wybór.");
                                break;
                        }
                        break;
                }
            }
        }
    }
}
