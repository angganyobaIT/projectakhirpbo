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
using projectakhirpbo.Controller;

namespace projectakhirpbo.View
{
    public partial class TambahMenu : Form
    {
        public TambahMenu()
        {
            InitializeComponent();
        }

        private void TambahMenu_Load(object sender, EventArgs e)
        {
            string sql = "select id_kategori, nama_kategori from kategori_menu";

            DataTable data = new DataTable();
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                    comboBox1.DataSource = data;
                    comboBox1.DisplayMember = "nama_kategori";   // Kolom yang ditampilkan
                    comboBox1.ValueMember = "id_kategori";           // Kolom nilai
                    comboBox1.SelectedIndex = -1;             // Tidak memilih default

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                var selectedId = comboBox1.SelectedValue;
                var selectedText = comboBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                var selectedId = comboBox1.SelectedValue;
                var selectedText = comboBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelolaMenu kembali = new KelolaMenu();
            kembali.Show();
            this.Hide();
        }
    }
}
