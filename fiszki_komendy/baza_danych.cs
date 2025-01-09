using Microsoft.Data.SqlClient;
using System;
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


        public (string, string) Słowo() {
            Console.WriteLine("hello");
            string ang_slowo = "xxx";
            string id_string = "sss";
            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");

                    string query = "SELECT TOP 1 id, slowo FROM Fiszki ORDER BY NEWID();";
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


    }


}

