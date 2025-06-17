using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Controller
{
    class AdminLoginController
    {
        public bool Validasi_admin(string username, string password, out int adminId)
        {
            adminId = 0;


            string sql = @"
    SELECT id_admin 
    FROM ""admin""
    WHERE username = @username AND ""password"" = @password
    LIMIT 1;
";


            using (var conn = Database.GetConnection())
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            adminId = reader.GetInt32(0);
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}