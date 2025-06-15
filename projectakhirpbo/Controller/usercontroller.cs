using System;
using System.Windows.Forms;
using Npgsql;
using projectakhirpbo.Model;

namespace projectakhirpbo.Controller
{
    public static class UserController
    {
        public static bool IsUsernameExists(string username)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM customer WHERE username = @username";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool RegisterCustomer(Customer newCustomer)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO customer (username, email, password) 
                                     VALUES (@username, @email, @password)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", newCustomer.Username);
                        cmd.Parameters.AddWithValue("@email", newCustomer.Email);
                        cmd.Parameters.AddWithValue("@password", newCustomer.Password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan data: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}