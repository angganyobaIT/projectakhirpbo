using Npgsql;
using projectakhirpbo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projectakhirpbo.Controller
{
    public class ReservasiAdminController
    {
        public static List<M_ReservasiAdmin> get_reservasi()
        {
            List<M_ReservasiAdmin> resev = new List<M_ReservasiAdmin>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql_data = "select a.id_reservasi, a.nama_lengkap,a.tanggal_kedatangan,a.waktu_kedatangan,c.jenis_ruangan,a.status_reservasi,b.status_pembayaran,b.waktu_transaksi,b.id_transaksi,c.id_ruangan  from reservasi a join transaksi b using (id_transaksi) join ruangan c using (id_ruangan) where a.status_reservasi != 'Selesai'";
                    using (var cmd = new NpgsqlCommand(sql_data, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resev.Add(new M_ReservasiAdmin
                            {
                                id_reservasi = reader.GetInt32(0),
                                nama_lengkap = reader.GetString(1),
                                tanggal_kedatangan = reader.GetDateTime(2),
                                waktu_kedatangan = reader.GetTimeSpan(3),
                                jenis_ruangan = reader.GetString(4),
                                status_reservasi = reader.GetString(5),
                                status_pembayaran = reader.GetString(6),
                                waktu_pembayaran = reader.GetDateTime(7),
                                id_transaksi = reader.GetInt32(8),
                                id_ruangan = reader.GetInt32(9)

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

            return resev;
        }
        public static bool Setuju_resev(int idReservasi)
        {
            const string sql = @"UPDATE reservasi SET status_reservasi = 'Disetujui' WHERE id_reservasi = @id_reservasi";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_reservasi", idReservasi);
                        int affected = cmd.ExecuteNonQuery();
                        return affected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error saat menghapus data menu: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool Tolak_resev(int idReservasi)
        {
            const string sql = @"UPDATE reservasi SET status_reservasi = 'Ditolak' WHERE id_reservasi = @id_reservasi";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_reservasi", idReservasi);
                        int affected = cmd.ExecuteNonQuery();
                        return affected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error saat menghapus data menu: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool Selesai_resev(int idReservasi)
        {
            const string sql = @"UPDATE reservasi SET status_reservasi = 'Selesai' WHERE id_reservasi = @id_reservasi";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_reservasi", idReservasi);
                        int affected = cmd.ExecuteNonQuery();
                        return affected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error saat menghapus data menu: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

    }

}