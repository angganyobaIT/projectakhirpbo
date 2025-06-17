using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using projectakhirpbo.Model;
using static projectakhirpbo.Model.MenuModel;

namespace projectakhirpbo.Controller
{
    public class MenuController
    {
        public static DataTable GetAllMenus()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT id_menu, nama_menu, harga FROM menu";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengambil data menu: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public static DataTable GetSelectedMenus(int idReservasi)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT dr.id_detail_reservasi, m.nama_menu, m.harga, dr.kuantitas_menu
                                   FROM detail_reservasi dr
                                   JOIN menu m ON dr.id_menu = m.id_menu
                                   WHERE dr.id_reservasi = @id_reservasi";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_reservasi", idReservasi);

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengambil data menu terpilih: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public static int GetTotalPayment(int idReservasi)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT SUM(m.harga * dr.kuantitas_menu) as total
                       FROM detail_reservasi dr
                       JOIN menu m ON dr.id_menu = m.id_menu
                       WHERE dr.id_reservasi = @id_reservasi";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_reservasi", idReservasi);
                    var result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToInt32(result);
                }
            }
        }
        public static bool SaveOrderDetails(int idReservasi, List<SelectedMenuModel> selectedMenus)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    // Hapus dulu yang sudah ada (jika ada) untuk menghindari duplikasi
                    string deleteQuery = "DELETE FROM detail_reservasi WHERE id_reservasi = @id_reservasi";
                    using (var deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@id_reservasi", idReservasi);
                        deleteCmd.ExecuteNonQuery();
                    }

                    // Insert yang baru
                    string insertQuery = "INSERT INTO detail_reservasi (id_menu, kuantitas_menu,id_reservasi) VALUES (@id_menu, @kuantitas,@id_reservasi) ";
                    foreach (var menu in selectedMenus)
                    {
                        using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                        {
                            //insertCmd.Parameters.AddWithValue("@id_reservasi", idReservasi);
                            insertCmd.Parameters.AddWithValue("@id_menu", menu.IdMenu);
                            insertCmd.Parameters.AddWithValue("@kuantitas", menu.Quantity);
                            insertCmd.Parameters.AddWithValue("@id_reservasi", idReservasi);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan detail pesanan: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //public static bool SimpanPesanan(int idMenu, int kuantitas)
        //{
        //    // Pastikan ada reservasi aktif
        //    if (reservation_session.CurrentReservid == 0)
        //        return false;

        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();
        //        string query = @"INSERT INTO detail_reservasi 
        //                        (id_reservasi, id_menu, kuantitas_menu) 
        //                        VALUES (@id_reservasi, @id_menu, @kuantitas)";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id_reservasi", reservation_session.CurrentReservid);
        //            cmd.Parameters.AddWithValue("@id_menu", idMenu);
        //            cmd.Parameters.AddWithValue("@kuantitas", kuantitas);

        //            return cmd.ExecuteNonQuery() > 0;
        //        }
        //    }
        //}
    }
}