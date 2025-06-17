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
    public partial class HistoryMenu : Form
    {
        public HistoryMenu()
        {
            InitializeComponent();
        }

        private void HistoryMenu_Load(object sender, EventArgs e)
        {
            List<M_Menu> menus = MenuAdminController.get_menu_history();
            dataGridView1.DataSource = menus;
            dataGridView1.Columns["id_menu"].Visible = false;
            dataGridView1.Columns["id_kategori"].Visible = false;
            dataGridView1.Columns["Dihapus"].Visible = false;
            if (dataGridView1.Columns["btnRestore"] != null)
                dataGridView1.Columns.Remove("btnRestore");
            var btnRestore = new DataGridViewButtonColumn
            {
                HeaderText = "Restroe",
                Name = "btnRestore",
                Text = "Restroe",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dataGridView1.Columns.Add(btnRestore);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "btnRestore")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id_menu = Convert.ToInt32(row.Cells["id_menu"].Value);
                bool berhasil = MenuAdminController.RestoreMenu(id_menu);
                if (berhasil)
                {
                    MessageBox.Show("Data Berhasil Dihapus Silahkan Refresh", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
