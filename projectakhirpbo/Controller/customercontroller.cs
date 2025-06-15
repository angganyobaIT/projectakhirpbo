using System;
using Npgsql;
using projectakhirpbo.Model;

namespace projectakhirpbo.Controller
{
    class CustomerController
    {
        public static int ValidateCustomer(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT id_customer 
                               FROM customer 
                               WHERE username = @username AND password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0); // Return ID customer jika valid
                        }
                    }
                }
            }
            return 0; // Return 0 jika tidak valid (asumsi ID customer tidak ada yang 0)
        }
    }
}