using System;
using System.Windows.Forms;
using Npgsql;
using projectakhirpbo.Model;

namespace projectakhirpbo.Controller
{
    public static class UserController
    {
        public static bool IsUsernameExists(string username)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM customer WHERE username = @username";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool RegisterCustomer(Customer newCustomer)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO customer (username, email, password) 
                                     VALUES (@username, @email, @password)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", newCustomer.Username);
                        cmd.Parameters.AddWithValue("@email", newCustomer.Email);
                        cmd.Parameters.AddWithValue("@password", newCustomer.Password);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan data: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //public static List<ReservasiModel> Get_Resev_Customer(int idCustomer)
        //{
        //    var list = new List<ReservasiModel>();

        //    try
        //    {
        //        using (var conn = Database.GetConnection())
        //        {
        //            conn.Open();
        //            string sql = @"
        //        SELECT 
        //            m.id_reservasi         AS ""IdReservasi"",
        //            m.nama_lengkap         AS ""NamaCustomer"",
        //            m.tanggal_kedatangan   AS ""TanggalReservasi"",
        //            m.waktu_kedatangan     AS ""WaktuReservasi"",
        //            m.jumlah_orang         AS ""JumlahOrang"",
        //            m.status_reservasi     AS ""StatusReservasi"",
        //            k.jenis_ruangan        AS ""JenisRuangan""
        //        FROM reservasi m
        //        JOIN ruangan k 
        //          ON m.id_ruangan = k.id_ruangan
        //        WHERE m.id_customer = @id_customer;
        //    ";

        //            using (var cmd = new NpgsqlCommand(sql, conn))
        //            {
        //                cmd.Parameters.AddWithValue("id_customer", idCustomer);

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    // ambil posisi kolom sekali saja
        //                    int ordId = reader.GetOrdinal("IdReservasi");
        //                    int ordNama = reader.GetOrdinal("NamaCustomer");
        //                    int ordTanggal = reader.GetOrdinal("TanggalReservasi");
        //                    int ordWaktu = reader.GetOrdinal("WaktuReservasi");
        //                    int ordJumlah = reader.GetOrdinal("JumlahOrang");
        //                    int ordStatus = reader.GetOrdinal("StatusReservasi");
        //                    int ordJenisRoom = reader.GetOrdinal("JenisRuangan");

        //                    while (reader.Read())
        //                    {
        //                        list.Add(new ReservasiModel
        //                        {
        //                            IdReservasi = reader.GetInt32(ordId),
        //                            NamaCustomer = reader.GetString(ordNama),
        //                            TanggalReservasi = reader.GetDateTime(ordTanggal),
        //                            WaktuReservasi = reader.GetTimeSpan(ordWaktu),
        //                            JumlahOrang = reader.GetInt32(ordJumlah),
        //                            status_reservasi = reader.GetString(ordStatus),
        //                            jenis_ruangan = reader.GetString(ordJenisRoom),
        //                            IdCustomer = idCustomer
        //                        });
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error saat mengambil data reservasi: " + ex.Message,
        //                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return list;
        //}
        public static List<ReservasiModel> Get_Resev_Customer(int id)
        {
            var resev = new List<ReservasiModel>();
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = @"
SELECT 
    m.id_reservasi    AS ""id_reservasi"",
    m.nama_lengkap    AS ""Nama"",
    m.no_telp         AS ""No_telp"",
    m.tanggal_kedatangan AS ""Tanggal"",
    m.waktu_kedatangan   AS ""Jam"",
    m.jumlah_orang       AS ""Jumlah Orang"",
    m.status_reservasi   AS ""Status"",
    k.jenis_ruangan      AS ""Tempat""
FROM reservasi m
JOIN ruangan k 
  ON m.id_ruangan = k.id_ruangan
WHERE m.id_customer = @id_customer;
";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_customer", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resev.Add(new ReservasiModel
                                {
                                    IdReservasi = reader.GetInt32(0),
                                    NamaCustomer = reader.GetString(1),
                                    No_telp = reader.GetString(2),
                                    TanggalReservasi = reader.GetDateTime(3),
                                    WaktuReservasi = reader.GetTimeSpan(4),
                                    JumlahOrang = reader.GetInt32(5),
                                    status_reservasi = reader.GetString(6),   // contoh: PascalCase
                                    jenis_ruangan = reader.GetString(7),
                                    IdCustomer = id
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengambil data: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resev;
        }
        //public static List<ReservasiModel> Get_Resev_Customer(int id)
        //{
        //    List<ReservasiModel> resev = new List<ReservasiModel>();

        //    try
        //    {
        //        using (var conn = Database.GetConnection())
        //        {
        //            conn.Open();
        //            string sql_data = @"
        //    SELECT 
        //        m.id_reservasi    AS ""id_reservasi"",
        //        m.nama_lengkap    AS ""Nama"",
        //        m.no_telp   AS    ""No_telp"",
        //        m.tanggal_kedatangan AS ""Tanggal"",
        //        m.waktu_kedatangan   AS ""Jam"",
        //        m.jumlah_orang       AS ""Jumlah Orang"",
        //        m.status_reservasi   AS ""Status"",
        //        k.jenis_ruangan      AS ""Tempat""
        //    FROM reservasi m
        //    JOIN ruangan k 
        //      ON m.id_ruangan = k.id_ruangan
        //    WHERE m.id_customer = @id_customer;
        //";
        //            using (var cmd = new NpgsqlCommand(sql_data, conn))
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    resev.Add(new ReservasiModel
        //                    {
        //                        IdReservasi = reader.GetInt32(0),
        //                        NamaCustomer = reader.GetString(1),
        //                        No_telp = reader.GetString(2),
        //                        TanggalReservasi = reader.GetDateTime(3),
        //                        WaktuReservasi = reader.GetTimeSpan(4),
        //                        JumlahOrang = reader.GetInt32(5),
        //                        status_reservasi = reader.GetString(6),
        //                        jenis_ruangan = reader.GetString(7),
        //                        IdCustomer = id
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error saat mengambil data menu: " + ex.Message, "Error",
        //                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return resev;
        //}

        public static bool update_user(string user, string email, string pass, int id)
        {
            const string updateSql = @"
                    UPDATE Customer
                       SET username = @username,
                           email    = @email,
                           password = @password
                     WHERE ID_customer = @id";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(updateSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", pass);
                        cmd.Parameters.AddWithValue("@id", id);
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
