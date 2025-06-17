using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using projectakhirpbo.Model;

namespace projectakhirpbo.Controller
{
    public class MenuAdminController
    {
        public static bool Tambah_Menu(M_Menu menu)
        {
            try
            {
                var conn = Database.GetConnection();
                conn.Open();
                string sql_tambah = @"INSERT INTO menu (nama_menu, harga,dihapus,id_kategori)
VALUES (@nama,@harga,@dihapus,@id_kategori)";
                using (var cmd = new Npgsql.NpgsqlCommand(sql_tambah, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", menu.nama_menu);
                    cmd.Parameters.AddWithValue("@harga", menu.harga);
                    cmd.Parameters.AddWithValue("@dihapus", menu.Dihapus);
                    cmd.Parameters.AddWithValue("@id_kategori", menu.id_kategori);
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

        public static List<M_Menu> get_menu()
        {
            List<M_Menu> menus = new List<M_Menu>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql_data = "SELECT a.id_menu, a.nama_menu, a.harga, a.id_kategori,  b.nama_kategori FROM menu a JOIN kategori_menu b ON a.id_kategori = b.id_kategori WHERE a.dihapus = 0";
                    using (var cmd = new NpgsqlCommand(sql_data, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            menus.Add(new M_Menu
                            {
                                id_menu = reader.GetInt32(0),
                                nama_menu = reader.GetString(1),
                                harga = reader.GetInt32(2),   // atau GetInt32 jika kolom int
                                id_kategori = reader.GetInt32(3),
                                nama_kategori = reader.GetString(4)
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

            return menus;
        }
        public static List<M_Menu> get_menu_history()
        {
            List<M_Menu> menus = new List<M_Menu>();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql_data = "SELECT a.id_menu, a.nama_menu, a.harga, a.id_kategori,  b.nama_kategori FROM menu a JOIN kategori_menu b ON a.id_kategori = b.id_kategori WHERE a.dihapus = 1";
                    using (var cmd = new NpgsqlCommand(sql_data, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            menus.Add(new M_Menu
                            {
                                id_menu = reader.GetInt32(0),
                                nama_menu = reader.GetString(1),
                                harga = reader.GetInt32(2),   // atau GetInt32 jika kolom int
                                id_kategori = reader.GetInt32(3),
                                nama_kategori = reader.GetString(4)
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

            return menus;
        }
        public static bool HapusMenu(int idMenu)
        {
            const string sql = @"
                UPDATE menu
                SET dihapus = 1
                WHERE id_menu = @id_menu;
            ";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_menu", idMenu);
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
        public static bool Update_Menu(M_Menu menu)
        {
            Tambah_Menu(menu);
            //const string sql = @"
            //    insert menu
            //    SET nama_menu = @nama,
            //        harga      = @harga,
            //        id_kategori= @id_kategori
            //    WHERE id_menu = @id_menu;
            //";

            const string sql2 = @"
                UPDATE menu
                SET dihapus = 1
                WHERE id_menu = @id_menu;
            ";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql2, conn))
                    {
                        //cmd.Parameters.AddWithValue("@nama", menu.nama_menu);
                        //cmd.Parameters.AddWithValue("@harga", menu.harga);
                        //cmd.Parameters.AddWithValue("@id_kategori", menu.id_kategori);
                        cmd.Parameters.AddWithValue("@id_menu", menu.id_menu);
                        int affected = cmd.ExecuteNonQuery();
                        return affected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error saat update data menu: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool RestoreMenu(int idMenu)
        {
            const string sql = @"
                UPDATE menu
                SET dihapus = 0
                WHERE id_menu = @id_menu;
            ";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_menu", idMenu);
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