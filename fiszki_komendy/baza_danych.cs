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


        public void hello() {
            Console.WriteLine("hello");
            try
            {
                // Tworzymy obiekt połączenia
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Połączenie z bazą danych nawiązane!");

                    string query = "select * from fiszki";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                            
                        {
                            while (reader.Read()) 
                            {
                                int id = reader.GetInt32(0);
                                string slowo = reader.GetString(1);
                                Console.WriteLine($"id= {id}, słowo= {slowo}");
                            }


                        }


                    }

                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd połączenia: {ex.Message}");
            }



        }

    }
}
