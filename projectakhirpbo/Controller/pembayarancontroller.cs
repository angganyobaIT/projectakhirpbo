using System;
using Npgsql;
using projectakhirpbo.Model;
using projectakhirpbo.View;

namespace projectakhirpbo.Controller
{
    public class pembayarancontroller
    {
        public static int HitungTotal(int idReservasi)
        {
            // Hitung total harga menu yang dipesan
            string query = @"SELECT SUM(menu.harga * detail_reservasi.kuantitas_menu) 
                            FROM detail_reservasi 
                            join menu on menu.id_menu = detail_reservasi.id_menu";
                            //WHERE id_reservasi = @id";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", idReservasi);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static bool ProsesPembayaran(pembayaranmodel pembayaran)
        {
            // Mulai transaksi database
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Simpan data transaksi
                        string queryTransaksi = @"INSERT INTO transaksi 
                                               (id_reservasi, total, status) 
                                               VALUES (@id, @total, @status)";

                        using (var cmd = new NpgsqlCommand(queryTransaksi, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", pembayaran.IdReservasi);
                            cmd.Parameters.AddWithValue("@total", pembayaran.Total);
                            cmd.Parameters.AddWithValue("@status", pembayaran.Status);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update status reservasi
                        string queryReservasi = @"UPDATE reservasi 
                                               SET status = 'Dibayar' 
                                               WHERE id = @id";

                        using (var cmd = new NpgsqlCommand(queryReservasi, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", pembayaran.IdReservasi);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}