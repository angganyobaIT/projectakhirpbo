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
        public static bool registeruser(customer user)
        {
            try
            {
                var conn = Database.GetConnection();

                // Tambahkan pengecekan koneksi
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string query = "INSERT INTO customer (username, email, password) VALUES (@username, @email, @password)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat simpan ke database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}