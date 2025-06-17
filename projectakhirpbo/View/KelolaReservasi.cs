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
    public partial class KelolaReservasi : Form
    {
        public KelolaReservasi()
        {
            InitializeComponent();
        }

        private void KelolaReservasi_Load(object sender, EventArgs e)
        {
            List<M_ReservasiAdmin> resev = ReservasiAdminController.get_reservasi();
            dataGridView1.DataSource = resev;
            dataGridView1.Columns["id_transaksi"].Visible = false;
            dataGridView1.Columns["id_ruangan"].Visible = false;

            if (dataGridView1.Columns["btnSetuju"] != null)
                dataGridView1.Columns.Remove("btnSetuju");
            if (dataGridView1.Columns["btnTidakSetuju"] != null)
                dataGridView1.Columns.Remove("btnTidakSetuju");
            if (dataGridView1.Columns["btnLihatDetail"] != null)
                dataGridView1.Columns.Remove("btnLihatDetail");
            if (dataGridView1.Columns["btnSelesai"] != null)
                dataGridView1.Columns.Remove("btnSelesai");
            var btnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "Setuju",
                Name = "btnSetuju",
                Text = "Setuju",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnEdit);
            var btnHapus = new DataGridViewButtonColumn
            {
                HeaderText = "Tidak Setuju",
                Name = "btnTidakSetuju",
                Text = "Tidak Setuju",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnHapus);
            var btnSelesai = new DataGridViewButtonColumn
            {
                HeaderText = "Selesai",
                Name = "btnSelesai",
                Text = "Selesai",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnSelesai);
            var btnLihatDetail = new DataGridViewButtonColumn
            {
                HeaderText = "Detail",
                Name = "btnLihatDetail",
                Text = "Detail",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnLihatDetail);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "btnSetuju")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_reservasi = Convert.ToInt32(row.Cells["id_reservasi"].Value);
                bool setuju = ReservasiAdminController.Setuju_resev(id_reservasi);
                if (setuju)
                {
                    MessageBox.Show("Reservasi berhasil disetujui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menyetujui", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (colName == "btnTidakSetuju")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_reservasi = Convert.ToInt32(row.Cells["id_reservasi"].Value);
                bool tolak = ReservasiAdminController.Tolak_resev(id_reservasi);
                if (tolak)
                {
                    MessageBox.Show("Reservasi berhasil ditolak", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menolak", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (colName == "btnSelesai")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_reservasi = Convert.ToInt32(row.Cells["id_reservasi"].Value);
                bool selesai = ReservasiAdminController.Selesai_resev(id_reservasi);
                if (selesai)
                {
                    MessageBox.Show("Reservasi berhasil diselesaikan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menyelesaikan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (colName == "btnLihatDetail")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_reservasi = Convert.ToInt32(row.Cells["id_reservasi"].Value);

                DetailReservasi det = new DetailReservasi(id_reservasi);
                det.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageAdmin home = new HomepageAdmin();
            home.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelolaReservasi refresh = new KelolaReservasi();
            refresh.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KelolaMenu menu = new KelolaMenu();
            menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
