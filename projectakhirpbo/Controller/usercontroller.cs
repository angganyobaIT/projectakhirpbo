using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using projectakhirpbo.Model;

namespace projectakhirpbo.Controller
{
    public class usercontroller
    {
        public static int registeruser(customer user)
        {
            try
            {
                var conn = Database.GetConnection();
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string query = "INSERT INTO customer (username, email, password) VALUES (@username, @email, @password) RETURNING id_customer;";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    int id = (int)cmd.ExecuteScalar(); // Ambil id_customer yang baru dibuat
                    return id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat simpan ke database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}