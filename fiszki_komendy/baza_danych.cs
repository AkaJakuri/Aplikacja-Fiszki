using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiszki_komendy
{
    internal class baza_danych
    {

        string connectionString = @"Server=DESKTOP-JMS3Q0H\SQLEXPRESS;Database=Fiszki;Trusted_Connection=True ;Encrypt=False";


        // można dodać kategorię przez wpisanie jej id,
        //jak się nie poda id to będzie domyślnie los z wszystkich kategorii
        public (string, string) losowanie_słowa(int kategoria = 0) {
            Console.WriteLine("hello");
            string ang_slowo = "xxx";
            string id_string = "sss";
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
            return (ang_slowo,id_string);

        }


        public bool sprawdzenie(string ang_slowo, string id, string proba)
        {
            Console.WriteLine($"{ang_slowo},{id},{proba}");
            bool wynik = false;
            string tlumaczenie ="";
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
        




        public string podaj_zdanie(string id)
        {
            string zdanie ="brak zdania";
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









    }


}

