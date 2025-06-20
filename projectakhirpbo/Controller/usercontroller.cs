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
                string query = "SELECT COUNT(*) FROM akun WHERE username = @username";

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
            const int ROLE_CUSTOMER = 2;

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert ke tabel akun, ambil ID_akun yang baru
                        string sqlAkun = @"
                    INSERT INTO akun (username, password, id_role)
                    VALUES (@username, @password, @role)
                    RETURNING id_akun;
                ";
                        int newAkunId;
                        using (var cmdAkun = new NpgsqlCommand(sqlAkun, conn, tran))
                        {
                            cmdAkun.Parameters.AddWithValue("@username", newCustomer.Username);
                            cmdAkun.Parameters.AddWithValue("@password", newCustomer.Password);
                            cmdAkun.Parameters.AddWithValue("@role", ROLE_CUSTOMER);
                            newAkunId = (int)cmdAkun.ExecuteScalar();
                        }

                        // 2. Insert ke tabel customer, mengaitkan dengan ID_akun
                        string sqlCustomer = @"
                    INSERT INTO customer (email, id_akun)
                    VALUES (@email, @idAkun);
                ";
                        using (var cmdCust = new NpgsqlCommand(sqlCustomer, conn, tran))
                        {
                            cmdCust.Parameters.AddWithValue("@email", newCustomer.Email);
                            cmdCust.Parameters.AddWithValue("@idAkun", newAkunId);
                            cmdCust.ExecuteNonQuery();
                        }

                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error saat menyimpan data: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public static bool ValidateLogin(
    string username,
    string password,
    out int akunId,
    out int roleId,
    out int? customerId)
        {
            akunId = 0;
            roleId = 0;
            customerId = null;

            const string sql = @"
        SELECT 
            a.id_akun, 
            a.id_role, 
            c.id_customer
        FROM akun a
        LEFT JOIN customer c ON c.id_akun = a.id_akun
        WHERE a.username = @username
          AND a.password = @password;
    ";

            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return false;

                    akunId = reader.GetInt32(reader.GetOrdinal("id_akun"));
                    roleId = reader.GetInt32(reader.GetOrdinal("id_role"));

                    if (!reader.IsDBNull(reader.GetOrdinal("id_customer")))
                        customerId = reader.GetInt32(reader.GetOrdinal("id_customer"));

                    return true;
                }
            }
        }

        //public static bool RegisterCustomer(Customer newCustomer)
        //{
        //    try
        //    {
        //        using (var conn = Database.GetConnection())
        //        {
        //            conn.Open();
        //            string query = @"INSERT INTO customer (username, email, password) 
        //                             VALUES (@username, @email, @password)";

        //            using (var cmd = new NpgsqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@username", newCustomer.Username);
        //                cmd.Parameters.AddWithValue("@email", newCustomer.Email);
        //                cmd.Parameters.AddWithValue("@password", newCustomer.Password);

        //                int rowsAffected = cmd.ExecuteNonQuery();
        //                return rowsAffected > 0;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error saat menyimpan data: " + ex.Message, "Error",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
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
WHERE m.id_customer = @id_customer
AND m.status_reservasi != 'Selesai' AND m.status_reservasi != 'Dibatalkan';
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
        public static List<ReservasiModel> Get_Resev_history(int id)
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
WHERE m.id_customer = @id_customer
AND (m.status_reservasi = 'Selesai' or m.status_reservasi = 'Dibatalkan');
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
