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
    public partial class UbahMenu : Form
    {
        private readonly int _idMenu;
        private readonly int _idKategoriAwal;
        public UbahMenu(int idMenu, string namaMenu, decimal harga, int idKategori)
        {
            InitializeComponent();
            _idMenu = idMenu;
            _idKategoriAwal = idKategori;

            TB_nama_makanan.Text = namaMenu;
            TB_Harga.Text = harga.ToString();
        }

        private void UbahMenu_Load(object sender, EventArgs e)
        {
            // 1) Load daftar kategori
            var dt = new DataTable();
            const string sqlKategori = "SELECT id_kategori, nama_kategori FROM kategori_menu";
            using (var conn = Database.GetConnection())
            using (var cmd = new NpgsqlCommand(sqlKategori, conn))
            using (var da = new NpgsqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nama_kategori";
            comboBox1.ValueMember = "id_kategori";

            // 2) Pilih sesuai kategori yang dulu dipilih
            comboBox1.SelectedValue = _idKategoriAwal;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                var selectedId = comboBox1.SelectedValue;
                var selectedText = comboBox1.Text;
            }
        }

        private void btnmasuk_Click(object sender, EventArgs e)
        {
            // Validasi sederhana
            if (string.IsNullOrWhiteSpace(TB_nama_makanan.Text))
            {
                MessageBox.Show("Nama menu tidak boleh kosong");
                return;
            }
            if (!decimal.TryParse(TB_Harga.Text, out decimal harga) || harga < 0)
            {
                MessageBox.Show("Harga tidak valid");
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih kategori dahulu");
                return;
            }

            // 3) Bentuk model M_Menu
            var menu = new M_Menu
            {
                id_menu = _idMenu,
                nama_menu = TB_nama_makanan.Text.Trim(),
                harga = (int)harga,
                id_kategori = (int)comboBox1.SelectedValue
            };

            // 4) Panggil controller
            bool sukses = MenuAdminController.Update_Menu(menu);
            if (sukses)
            {
                MessageBox.Show("Data berhasil diupdate!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal mengupdate data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
