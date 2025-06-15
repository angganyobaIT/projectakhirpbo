using System;
using Npgsql;
using projectakhirpbo.Model;

namespace projectakhirpbo.Controller
{
    public class ReservasiController
    {
        public static int BuatReservasi(ReservasiModel reservasi)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO reservasi 
                        (nama_lengkap, tanggal_kedatangan, waktu_kedatangan, 
                         jumlah_orang, status_reservasi, id_customer, id_ruangan) 
                        VALUES 
                        (@nama, @tanggal, @waktu, @jumlah, @status, @customer, @ruangan)
                        RETURNING id_reservasi";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", reservasi.NamaCustomer);
                    cmd.Parameters.AddWithValue("@tanggal", reservasi.TanggalReservasi);
                    cmd.Parameters.AddWithValue("@waktu", reservasi.WaktuReservasi);
                    cmd.Parameters.AddWithValue("@jumlah", reservasi.JumlahOrang);
                    cmd.Parameters.AddWithValue("@status", "pending");
                    cmd.Parameters.AddWithValue("@customer", reservasi.IdCustomer);
                    cmd.Parameters.AddWithValue("@ruangan", reservasi.IdRuangan);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

    }
}