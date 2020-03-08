using System;
using MySql.Data.MySqlClient;

namespace DatabaseReview_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "---------------------------\n" +
                "- Database Review Project -\n" +
                "---------------------------\n" +
                "---   Weather Checker   ---\n" +
                "---------------------------\n");

            // Create the connection string
            string cs =
                @"server=127.0.0.1;userid=root;password=root;database=SampleAPIData;port=8889";

            // Create a new connection
            MySqlConnection conn = null;

            // Collect the userID
            Console.Write("Enter a City: ");
            string city = Console.ReadLine();

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                // SQL Query Statement
                string stm = "SELECT city, temp, pressure, humidity FROM weather WHERE city = @city ORDER BY createdDate DESC LIMIT 1;";


                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Binding variables
                cmd.Parameters.AddWithValue("@city", city);

                // Create a reader to read the data
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine(
                            $"\nCity:     {rdr["city"]}\n" +
                            $"Temp:     {rdr["temp"]}\n" +
                            $"Pressure: {rdr["pressure"]}\n" +
                            $"Humidity: {rdr["humidity"]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{city} does not have any available weather data!");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error:{0}", e.ToString());
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
