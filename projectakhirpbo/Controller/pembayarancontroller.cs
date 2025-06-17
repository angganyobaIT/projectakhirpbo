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
                            join menu on menu.id_menu = detail_reservasi.id_menu
                            Where id_reservasi = @id";
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
                    string queryReservasi = @"UPDATE transaksi 
                                               SET status_pembayaran = 'Diterima' 
                                               WHERE id_transaksi = @idtransaksi";

                    try
                    {
                        using (var cmd = new NpgsqlCommand(queryReservasi, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idtransaksi", pembayaran.id_transaksi);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Tampilkan pesan error
                        MessageBox.Show(ex.Message, "Error Exception");
                        transaction.Rollback();
                        return false;
                    }
                    //try
                    //{

                    //    using (var cmd = new NpgsqlCommand(queryReservasi, conn, transaction))
                    //    {
                    //        cmd.Parameters.AddWithValue("@idtransaksi", pembayaran.id_transaksi);
                    //        cmd.ExecuteNonQuery();
                    //    }

                    //    transaction.Commit();
                    //    return true;
                    //}
                    //catch
                    //{
                    //    transaction.Rollback();
                    //    return false;
                    //}
                }
            }
        }
    }
}