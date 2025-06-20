using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace projectakhirpbo.Controller
{
    class detailreservasicontroller
    {
        public static bool TambahMenu(int idMenu, int kuantitas, int id_reserv)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO detail_reservasi 
                               (id_menu, kuantitas_menu, id_reservasi) 
                               VALUES (@menu, @qty, @id_reservasi)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@menu", idMenu);
                    cmd.Parameters.AddWithValue("@qty", kuantitas);
                    cmd.Parameters.AddWithValue("@id_reservasi", id_reserv);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
