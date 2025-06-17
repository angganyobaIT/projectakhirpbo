using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectakhirpbo.Controller;
using projectakhirpbo.Model;

namespace projectakhirpbo.View
{
    public partial class KelolaMenu : Form
    {
        public KelolaMenu()
        {
            InitializeComponent();
        }

        private void KelolaMenu_Load(object sender, EventArgs e)
        {
            List<M_Menu> menus = MenuAdminController.get_menu();
            dataGridView1.DataSource = menus;
            dataGridView1.Columns["id_menu"].Visible = false;
            dataGridView1.Columns["id_kategori"].Visible = false;
            dataGridView1.Columns["Dihapus"].Visible = false;

            if (dataGridView1.Columns["btnEdit"] != null)
                dataGridView1.Columns.Remove("btnEdit");
            if (dataGridView1.Columns["btnHapus"] != null)
                dataGridView1.Columns.Remove("btnHapus");
            var btnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Name = "btnEdit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnEdit);
            var btnHapus = new DataGridViewButtonColumn
            {
                HeaderText = "Hapus",
                Name = "btnHapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnHapus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageAdmin home = new HomepageAdmin();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelolaReservasi reservasi = new KelolaReservasi();
            reservasi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KelolaMenu refresh = new KelolaMenu();
            refresh.Show();
            this.Hide();
        }

        private void btnmasuk_Click(object sender, EventArgs e)
        {
            TambahMenu tambah = new TambahMenu();
            tambah.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "btnEdit")
            {
                // Ambil data dari baris yang diklik
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_menu = Convert.ToInt32(row.Cells["id_menu"].Value);
                string nama_menu = row.Cells["nama_menu"].Value.ToString();
                decimal harga = Convert.ToDecimal(row.Cells["harga"].Value);
                int id_kategori = Convert.ToInt32(row.Cells["id_kategori"].Value);

                // Buka form UbahMenu dengan membawa data
                UbahMenu ubah = new UbahMenu(id_menu, nama_menu, harga, id_kategori);
                ubah.Show();
            }
            if (colName == "btnHapus")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_menu = Convert.ToInt32(row.Cells["id_menu"].Value);
                bool berhasil = MenuAdminController.HapusMenu(id_menu);
                if (berhasil)
                {
                    MessageBox.Show("Data Berhasil Dihapus Silahkan Refresh", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
