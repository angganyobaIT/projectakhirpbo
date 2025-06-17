using Npgsql;
using projectakhirpbo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Controller
{
    public class DetailReservasiAdmin
    {
        public static List<M_DetailReservasi> get_detail_reservasi(int id_reservasi)
        {
            List<M_DetailReservasi> detail = new List<M_DetailReservasi>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql_data = @"select a.id_detail_reservasi, b.nama_menu,a.kuantitas_menu,b.harga,a.kuantitas_menu * b.harga as subtotal
from detail_reservasi a
join menu b using (id_menu)
where id_reservasi =id_reservasi";

                    using (var cmd = new NpgsqlCommand(sql_data, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmd.Parameters.AddWithValue("id_reservasi", id_reservasi);
                            detail.Add(new M_DetailReservasi
                            {
                                id_detail_reservasi = reader.GetInt32(0),
                                nama_menu = reader.GetString(1),
                                kuantitas_menu = reader.GetInt32(2),
                                harga = reader.GetInt32(3),
                                subtotal = reader.GetInt32(4),
                                id_reservasi = id_reservasi
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengambil data menu: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return detail;
        }
    }
}