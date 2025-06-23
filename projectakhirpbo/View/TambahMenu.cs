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
using projectakhirpbo.Model;

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
            if(string.IsNullOrWhiteSpace(TB_nama_makanan.Text))
            {
                MessageBox.Show("Masukkan nama menu!");
                return;
            }
            if (!decimal.TryParse(TB_Harga.Text, out decimal harga) || harga < 0)
            {
                MessageBox.Show("Harga tidak valid!");
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih kategori terlebih dahulu!");
                return;
            }
            M_Menu menu = new M_Menu
            {
                nama_menu = TB_nama_makanan.Text.Trim(),
                harga = ((int)harga),
                Dihapus = 0,
                id_kategori = (int)comboBox1.SelectedValue

            };

            bool sukses = MenuAdminController.Tambah_Menu(menu);
            if (sukses)
            {
                MessageBox.Show("Data menu berhasil disimpan!");
                comboBox1.SelectedIndex = -1;
                TB_nama_makanan.Clear();
                TB_Harga.Clear();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data menu.");
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
