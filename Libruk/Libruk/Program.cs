using Libruk.Libruk;
using System;
using System.Data.SqlClient;

namespace Libruk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Połączenie z bazą danych
            string polaczeniezbaza = "Data Source=312-06;Initial Catalog=Librusprogram; Integrated Security=True";
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
                        Nauczyciel nauczyciel = new Nauczyciel(polaczenie);

                        // Pętla obsługująca menu
                        bool wyjscie = false;
                        while (!wyjscie)
                        {
                            // Wyświetlenie menu
                            Console.WriteLine("Menu:");
                            Console.WriteLine("1. Wyświetl oceny");
                            Console.WriteLine("2. Dodaj ocenę");
                            Console.WriteLine("3. Edytuj ocenę");
                            Console.WriteLine("4. Usuń ocenę");
                            Console.WriteLine("5. Wyjście");

                            Console.Write("Wybierz opcję: ");
                            string opcja = Console.ReadLine();

                            switch (opcja)
                            {
                                case "1":
                                    nauczyciel.WyswietlOceny();
                                    break;
                                case "2":
                                    nauczyciel.DodajOcene();
                                    break;
                                case "3":
                                    nauczyciel.EdytujOcene();
                                    break;
                                case "4":
                                    nauczyciel.UsunOcene();
                                    break;
                                case "5":
                                    wyjscie = true;
                                    break;
                                default:
                                    Console.WriteLine("Nieprawidłowa opcja.");
                                    break;
                            }

                            Console.WriteLine();
                        }

                        // Zamknięcie połączenia z bazą danych
                        polaczenie.Close();
                        break;
                    case 2:
                        Uczen uczen = new Uczen(polaczenie);

                        // Pętla obsługująca menu
                        bool wyjscie2 = false;
                        while (!wyjscie2)
                        {
                            // Wyświetlenie menu
                            Console.WriteLine("Menu:");
                            Console.WriteLine("1. Wyświetl oceny");
                            Console.WriteLine("2. Wyświetl uwagi");
                            Console.WriteLine("3. Wyjście");

                            Console.Write("Wybierz opcję: ");
                            string opcja = Console.ReadLine();

                            switch (opcja)
                            {
                                case "1":
                                    uczen.WyswietlOceny();
                                    break;
                                case "2":
                                    uczen.WyswietlUwagi();
                                    break;
                                case "3":
                                    wyjscie2 = true;
                                    break;
                                default:
                                    Console.WriteLine("Nieprawidłowa opcja.");
                                    break;
                            }

                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }
    }
}
