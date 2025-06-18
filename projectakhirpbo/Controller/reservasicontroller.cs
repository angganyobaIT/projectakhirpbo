using System;
using Npgsql;
using projectakhirpbo.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectakhirpbo.Controller
{
    public class ReservasiController
    {
        public static int BuatReservasi(ReservasiModel reservasi)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
        INSERT INTO reservasi 
            (nama_lengkap, no_telp,tanggal_kedatangan, waktu_kedatangan, 
             jumlah_orang, status_reservasi, id_transaksi, id_customer, id_ruangan)  
        VALUES 
            (@nama, @no_telp,@tanggal, @waktu, @jumlah, 'Pending', @transaksi, @customer, @ruangan)
        RETURNING id_reservasi;
    ";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama", reservasi.NamaCustomer);
            cmd.Parameters.AddWithValue("@no_telp", reservasi.No_telp);
            cmd.Parameters.AddWithValue("@tanggal", reservasi.TanggalReservasi);
            cmd.Parameters.AddWithValue("@waktu", reservasi.WaktuReservasi);
            cmd.Parameters.AddWithValue("@jumlah", reservasi.JumlahOrang);
            cmd.Parameters.AddWithValue("@transaksi", reservasi.IdTransaksi);
            cmd.Parameters.AddWithValue("@customer", reservasi.IdCustomer);
            cmd.Parameters.AddWithValue("@ruangan", reservasi.IdRuangan);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static bool UpdateReservasi(ReservasiModel reservasi)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
        UPDATE reservasi
           SET nama_lengkap      = @nama,
               no_telp           = @no_telp,
               tanggal_kedatangan= @tanggal,
               waktu_kedatangan  = @waktu,
               jumlah_orang      = @jumlah,
               id_ruangan        = @ruangan
         WHERE id_reservasi     = @id;
    ";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama", reservasi.NamaCustomer);
            cmd.Parameters.AddWithValue("@no_telp", reservasi.No_telp);
            cmd.Parameters.AddWithValue("@tanggal", reservasi.TanggalReservasi);
            cmd.Parameters.AddWithValue("@waktu", reservasi.WaktuReservasi);
            cmd.Parameters.AddWithValue("@jumlah", reservasi.JumlahOrang);
            cmd.Parameters.AddWithValue("@ruangan", reservasi.IdRuangan);
            cmd.Parameters.AddWithValue("@id", reservasi.IdReservasi);

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        //public static int BuatReservasi(ReservasiModel reservasi)
        //{
        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();

        //        string query = @"INSERT INTO reservasi 
        //                (nama_lengkap, tanggal_kedatangan, waktu_kedatangan, 
        //                 jumlah_orang, status_reservasi, id_customer, id_ruangan) 
        //                VALUES 
        //                (@nama, @tanggal, @waktu, @jumlah, @status, @customer, @ruangan)
        //                RETURNING id_reservasi";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@nama", reservasi.NamaCustomer);
        //            cmd.Parameters.AddWithValue("@tanggal", reservasi.TanggalReservasi);
        //            cmd.Parameters.AddWithValue("@waktu", reservasi.WaktuReservasi);
        //            cmd.Parameters.AddWithValue("@jumlah", reservasi.JumlahOrang);
        //            cmd.Parameters.AddWithValue("@status", "pending");
        //            cmd.Parameters.AddWithValue("@customer", reservasi.IdCustomer);
        //            cmd.Parameters.AddWithValue("@ruangan", reservasi.IdRuangan);

        //            return Convert.ToInt32(cmd.ExecuteScalar());
        //        }
        //    }
        //}

        public static int Transaksi(pembayaranmodel pembayaranmodel)
        {
            try
            {
                using var conn = Database.GetConnection();
                conn.Open();

                // Kita tambahkan RETURNING id_transaksi
                string sql_tambah = @"
            INSERT INTO transaksi (waktu_transaksi, status_pembayaran)
            VALUES (@waktu_transaksi, 'Pending')
            RETURNING id_transaksi;
        ";

                using var cmd = new Npgsql.NpgsqlCommand(sql_tambah, conn);
                cmd.Parameters.AddWithValue("@waktu_transaksi", pembayaranmodel.waktu_pembayaran);

                // ExecuteScalar akan mengembalikan kolom pertama dari baris yang di-RETURNING
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat simpan ke database: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indikasikan gagal
            }
        }
        //        public static bool transaksi (pembayaranmodel pembayaranmodel)
        //        {
        //            try
        //            {
        //                var conn = Database.GetConnection();
        //                conn.Open();
        //                string sql_tambah = @"INSERT INTO transaksi (waktu_transaksi, status_pembayaran)
        //VALUES (@waktu_transaksi,'Diterima')";
        //                using (var cmd = new Npgsql.NpgsqlCommand(sql_tambah, conn))
        //                {
        //                    cmd.Parameters.AddWithValue("@waktu_transaksi", pembayaranmodel.waktu_pembayaran);
        //                    cmd.ExecuteNonQuery();
        //                }
        //                conn.Close();
        //                return true;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error saat simpan ke database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }

    }
}