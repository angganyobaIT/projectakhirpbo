using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class Customer_Contex
    {
        public bool Validasi(string username, string password, out int customerId)
        {
            customerId = 0;

            // Query: sesuaikan nama tabel & kolom di database-mu
            string sql = @"
                SELECT id_customer 
                FROM customer 
                WHERE username = @username 
                  AND password = @password
                LIMIT 1;
            ";

            // Ambil koneksi dari helper Database
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Parameterisasi untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerId = reader.GetInt32(0);
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
