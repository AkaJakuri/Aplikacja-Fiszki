using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace fiszki_aplikacja_okienkowa
{
    internal class Baza_danych
    {
        string connectionString = @"Server=DESKTOP-JMS3Q0H\SQLEXPRESS;Database=Fiszki;Trusted_Connection=True ;Encrypt=False";


        // można dodać kategorię przez wpisanie jej id,
        //jak się nie poda id to będzie domyślnie los z wszystkich kategorii
        public (string, string) losowanie_słowa(int kategoria = 0)
        {

            string ang_slowo = "";
            string id_string = "";
            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query;
                    if (kategoria == 0)
                    {
                        query = "SELECT TOP 1 id, slowo FROM Fiszki ORDER BY NEWID();";
                    }
                    else
                    {
                        query = $"SELECT TOP 1 id, slowo FROM Fiszki where kategoriaID = {kategoria} ORDER BY NEWID();";
                    }
                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            while (reader.Read())
                            {

                                int id = reader.GetInt32(0);
                                id_string = id.ToString();
                                string slowo = reader.GetString(1);
                                Console.WriteLine($"id= {id}, słowo= {slowo}");
                                ang_slowo = slowo.ToLower();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd połączenia: {ex.Message}");
            }
            return (ang_slowo, id_string);

        }



        //sprawdzanie czy tłumaczenie użytownika jest poprawne
        public bool sprawdzenie(string ang_slowo, string id, string proba)
        {
            Console.WriteLine($"{ang_slowo},{id},{proba}");
            bool wynik = false;
            string tlumaczenie = "";
            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");

                    string query = $"select tlumaczenie from fiszki where id={id}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            while (reader.Read())
                            {
                                tlumaczenie = reader.GetString(0);
                                Console.WriteLine(tlumaczenie);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd połączenia: {ex.Message}");
            }

            if (tlumaczenie == proba)
            {
                wynik = true;
                Console.WriteLine("sie udało ");

            }
            else
            {
                Console.WriteLine("nie da się");
            }


            return wynik;


        }




        //generuje słownik z typami danych int i string, są to kategorie i ich id
        public Dictionary<int, string> lista_kategorii()
        {

            Dictionary<int, string> kategorie = new Dictionary<int, string>();

            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "select id,nazwa from kategorie";

                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            while (reader.Read())
                            {

                                int id = reader.GetInt32(0);
                                string nazwa = reader.GetString(1);
                                kategorie.Add(id, nazwa);
                                Console.WriteLine($"do bazy dodano {id},{nazwa}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd połączenia: {ex.Message}");
            }



            return kategorie;
        }





        ////podanie zdania do słowa po id 
        public string podaj_zdanie(string id)
        {
            string zdanie = "brak zdania";
            Console.WriteLine($"id w funkcji podaj to {id}");
            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"select ZdaniePrzyklad from fiszki where id={id}";

                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            while (reader.Read())
                            {
                                zdanie = reader.GetString(0);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd połączenia: {ex.Message}");
            }





            return zdanie;
        }





        //dodanie nowej fiszki do bazy danych 
        public void dodanie_fiszki(string slowo, string tlumaczenie, string ZdaniePrzyklad, int kategoriaID, int PoziomTrudnosciId)
        {
            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"INSERT INTO Fiszki " +
                        $"(slowo, tlumaczenie, ZdaniePrzyklad, kategoriaID, PoziomTrudnosciId) " +
                        $"VALUES (@slowo, @tlumaczenie, @ZdaniePrzyklad, @kategoriaID, @PoziomTrudnosciId);";

                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@slowo", slowo);
                        command.Parameters.AddWithValue("@tlumaczenie", tlumaczenie);
                        command.Parameters.AddWithValue("@ZdaniePrzyklad", ZdaniePrzyklad);
                        command.Parameters.AddWithValue("@kategoriaID", kategoriaID);
                        command.Parameters.AddWithValue("@PoziomTrudnosciId", PoziomTrudnosciId);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Dodano {rowsAffected} rekord(ów) do tabeli Fiszki.");
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd połączenia: {ex.Message}");
            }



        }



        //obiekt fiszka potrzebne do wypisania wszystkich fiszek (potrzebne aby była lista)
        public class Fiszka
        {
            public int Id { get; set; }
            public string Slowo { get; set; }
            public string Tlumaczenie { get; set; }
            public string ZdaniePrzyklad { get; set; }
            public int KategoriaID { get; set; }
            public int PoziomTrudnosciId { get; set; }
        }


        //wypisanie wszystkich fiszek (całe rekordy)
        //jak do wywołania doda się kategorie to wypisze z kategorii
        //jak się nie da kategorii to wypisze wszystko
        public List<Fiszka> wypisz_fiszki(int kategoria = 0)
        {
            List<Fiszka> fiszki = new List<Fiszka>();

            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "";
                    if (kategoria == 0)
                    {
                        query = $"SELECT id, slowo, tlumaczenie, ZdaniePrzyklad, kategoriaID, PoziomTrudnosciId FROM Fiszki";
                    }
                    else
                    {
                        query = $"SELECT id, slowo, tlumaczenie, ZdaniePrzyklad, kategoriaID, PoziomTrudnosciId FROM Fiszki where kategoriaID = {kategoria}";
                    }


                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string slo = reader.GetString(1);
                                string tlu = reader.GetString(2);
                                string zd = reader.GetString(3);
                                int kat = reader.GetInt32(4);
                                int poz = reader.GetInt32(5);
                                //Console.WriteLine($"{id}, {slo}, {tlu}, {zd}, {kat}, {poz}");

                                fiszki.Add(new Fiszka
                                {
                                    Id = reader.GetInt32(0),
                                    Slowo = reader.GetString(1),
                                    Tlumaczenie = reader.GetString(2),
                                    ZdaniePrzyklad = reader.GetString(3),
                                    KategoriaID = reader.GetInt32(4),
                                    PoziomTrudnosciId = reader.GetInt32(5)
                                });

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd połączenia: {ex.Message}");
            }


            return fiszki;

        }
    }
}
