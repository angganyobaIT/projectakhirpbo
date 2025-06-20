using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using projectakhirpbo.Model;
using static System.Collections.Specialized.BitVector32;

namespace projectakhirpbo.View
{
    public partial class HomepageAdmin : Form
    {
        public HomepageAdmin()
        {
            InitializeComponent();
        }

        private void HomepageAdmin_Load(object sender, EventArgs e)
        {
            int id = UserSession.CurrentUserId;
            string name = UserSession.CurrentUsername;

            string sql_data = "select a.id_reservasi, a.nama_lengkap,a.tanggal_kedatangan,a.waktu_kedatangan,c.jenis_ruangan,b.status_pembayaran,b.waktu_transaksi from reservasi a join transaksi b using (id_transaksi) join ruangan c using (id_ruangan)";

            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql_data, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            LB_admin_nama.Text = name;
            string sql = @"select count (id_reservasi) from reservasi where status_reservasi != 'Selesai' ;";
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        int jumlahReservasi = Convert.ToInt32(cmd.ExecuteScalar());
                        LB_Jumlah_resv.Text = jumlahReservasi.ToString();
                    }
                }
                catch (Exception ex)
                {
                    LB_Jumlah_resv.Text = "Error: " + ex.Message;
                }
            }

            string sql2 = @"select count (id_menu) from menu where dihapus = 0;";
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql2, conn))
                    {
                        int jumlahReservasi = Convert.ToInt32(cmd.ExecuteScalar());
                        LB_jumlah_Menu.Text = jumlahReservasi.ToString();
                    }
                }
                catch (Exception ex)
                {
                    LB_jumlah_Menu.Text = "Error: " + ex.Message;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageAdmin refresh = new HomepageAdmin();
            refresh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelolaReservasi resev = new KelolaReservasi();
            resev.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KelolaMenu menu = new KelolaMenu();
            menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            this.Close();
        }
    }
}
