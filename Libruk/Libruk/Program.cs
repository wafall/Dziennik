using System;
using System.Data.SqlClient;

namespace Libruk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Połączenie z bazą danych
            string connectionString = "Data Source=(local);Initial Catalog=SchoolJournal;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Menu wyboru panelu (nauczyciel, uczeń, rodzic)
                Console.WriteLine("Wybierz panel:");
                Console.WriteLine("1. Nauczyciel");
                Console.WriteLine("2. Uczeń/Rodzic");
                int panelChoice = Convert.ToInt32(Console.ReadLine());

                switch (panelChoice)
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
                        int gradeChoice = Convert.ToInt32(Console.ReadLine());

                        switch (gradeChoice)
                        {
                            case 1:
                                // Wyświetlenie ocen
                                Console.WriteLine("Wyświetlanie ocen:");

                                SqlCommand command = new SqlCommand("SELECT * FROM Grades", connection);
                                SqlDataReader reader = command.ExecuteReader();

                                while (reader.Read())
                                {
                                    Console.WriteLine($"{reader["Subject"]} - {reader["Grade"]}");
                                }

                                reader.Close();
                                break;

                            case 2:
                                // Dodanie oceny
                                Console.WriteLine("Dodawanie oceny:");
                                Console.WriteLine("Podaj przedmiot:");
                                string subject = Console.ReadLine();
                                Console.WriteLine("Podaj ocenę:");
                                int grade = Convert.ToInt32(Console.ReadLine());

                                command = new SqlCommand($"INSERT INTO Grades (Subject, Grade) VALUES ('{subject}', {grade})", connection);
                                command.ExecuteNonQuery();
                                Console.WriteLine("Dodano ocenę.");
                                break;

                            case 3:
                                // Edycja oceny
                                Console.WriteLine("Edytowanie oceny:");
                                Console.WriteLine("Podaj ID oceny:");
                                int gradeId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Podaj nową ocenę:");
                                int newGrade = Convert.ToInt32(Console.ReadLine());

                                command = new SqlCommand($"UPDATE Grades SET Grade = {newGrade} WHERE Id = {gradeId}", connection);
                                command.ExecuteNonQuery();
                                Console.WriteLine("Zaktualizowano ocenę.");
                                break;

                            case 4:
                                // Usunięcie oceny
                                Console.WriteLine("Usuwanie oceny:");
                                Console.WriteLine("Podaj ID oceny:");
                                gradeId = Convert.ToInt32(Console.ReadLine());

                                command = new SqlCommand($"DELETE FROM Grades WHERE Id = {gradeId}", connection);
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
