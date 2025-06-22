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
            var detail = new List<M_DetailReservasi>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    const string sql_data = @"
                SELECT a.id_detail_reservasi,
                       b.nama_menu,
                       a.kuantitas_menu,
                       b.harga,
                       a.kuantitas_menu * b.harga AS subtotal
                  FROM detail_reservasi a
                  JOIN menu b USING (id_menu)
                 WHERE id_reservasi = @id_reservasi";  

                    using (var cmd = new NpgsqlCommand(sql_data, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_reservasi", id_reservasi);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengambil data menu: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return detail;
        }


    }
}