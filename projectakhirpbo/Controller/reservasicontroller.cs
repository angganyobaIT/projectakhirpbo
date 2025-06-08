using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectakhirpbo.Model;
using projectakhirpbo.View;

namespace projectakhirpbo.Controller
{
    class reservasicontroller
    {
        public static bool Reservasi(reservasimodel reserv, customer cust)
        {
            try
            {
                var conn = Database.GetConnection();
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                string query = "INSERT INTO reservasi (nama_lengkap, nomor_telepon, tanggal_kedatangan, waktu_kedatangan, jumlah_orang, customer_id_customer, meja_no_meja) VALUES (@nama_lengkap, @nomor_telepon, @tanggal_datang, @waktu_datang, @jumlah_orang, @customer_id, @nomor_meja)";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                { 
                    cmd.Parameters.AddWithValue("@nama_lengkap",reserv.namaCustomer);
                    cmd.Parameters.AddWithValue("@nomor_telepon", reserv.noTeleponCustomer);
                    cmd.Parameters.AddWithValue("@tanggal_datang", reserv.tanggalReservasi);
                    cmd.Parameters.AddWithValue("@waktu_datang", reserv.waktuReservasi);
                    cmd.Parameters.AddWithValue("@jumlah_orang", reserv.jumlahOrang);
                    cmd.Parameters.AddWithValue("@customer_id", cust.id_customer);
                    cmd.Parameters.AddWithValue("@nomor_meja", reserv.meja);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat simpan ke database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }

}


