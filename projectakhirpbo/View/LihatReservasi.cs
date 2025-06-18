using projectakhirpbo.Controller;
using projectakhirpbo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectakhirpbo.View
{
    public partial class LihatReservasi : Form
    {
        //private readonly int id_customer; int id_customer
        public LihatReservasi()
        {
            InitializeComponent();
            //this.id_customer = id_customer;

        }

        private void LihatReservasi_Load(object sender, EventArgs e)
        {

            List<ReservasiModel> resev = UserController.Get_Resev_Customer(UserSession.CurrentUserId);
            dataGridView1.DataSource = resev;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Columns["IdReservasi"].Visible = false;
            dataGridView1.Columns["IdCustomer"].Visible = false;
            dataGridView1.Columns["IdRuangan"].Visible = false;
            dataGridView1.Columns["IdTransaksi"].Visible = false;
            var btnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Name = "btnEdit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnEdit);

            // 4. Tambah kolom tombol Batalkan
            var btnBatal = new DataGridViewButtonColumn
            {
                HeaderText = "Batalkan",
                Name = "btnBatal",
                Text = "Batalkan",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(btnBatal);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "btnEdit")
            {
                //MessageBox.Show("Data Berhasil Dihapus Silahkan Refresh", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string nama = row.Cells["NamaCustomer"].Value.ToString();
                string no_telp = row.Cells["No_telp"].Value.ToString();
                DateTime tanggal = Convert.ToDateTime(row.Cells["TanggalReservasi"].Value);
                TimeSpan waktu = (TimeSpan)row.Cells["WaktuReservasi"].Value;
                int jumlah = Convert.ToInt32(row.Cells["JumlahOrang"].Value);
                string ruang = row.Cells["jenis_ruangan"].Value.ToString();
                int id_reservasi = Convert.ToInt32(row.Cells["IdReservasi"].Value);

                EditReservasi edit = new EditReservasi(nama, no_telp, tanggal, waktu, jumlah, ruang, id_reservasi);
                edit.Show();
            }
            if (colName == "btnBatal")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_reservasi = Convert.ToInt32(row.Cells["IdReservasi"].Value);
                bool berhasil = ReservasiController.BatalReservasi(id_reservasi);
                if (berhasil)
                {
                    MessageBox.Show("Reservasi Berhasil Dibatalkan Silahkan Menunggu admin untuk refund", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LihatReservasi reser = new LihatReservasi();
                    reser.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal membatalkan reservasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LihatReservasi reser = new LihatReservasi();
                    reser.Show();
                    this.Hide();
                }

            }
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void BTN_LihaResev_Click_1(object sender, EventArgs e)
        {
            LihatReservasi resev = new LihatReservasi();
            resev.Show();
            this.Hide();
        }

        private void BTN_Profil_Click_1(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            this.Close();
        }

        private void BTN_History_Click(object sender, EventArgs e)
        {
            historireservasi history = new historireservasi();
            history.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
