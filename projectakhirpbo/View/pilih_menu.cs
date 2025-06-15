using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projectakhirpbo.Controller;
using projectakhirpbo.Model;
using static projectakhirpbo.Model.MenuModel;

namespace projectakhirpbo.View
{
    public partial class pilih_menu : Form
    {
        private int currentReservationId;
        public pilih_menu(int reservationId)
        {
            InitializeComponent();
            currentReservationId = reservationId;
            LoadMenuData();
            AddButtonColumn();
            SetupPesananGrid();

        }

        private void LoadMenuData()
        {
            try
            {
                var menus = MenuController.GetAllMenus();
                dgrid_viewmenu.DataSource = menus;

                dgrid_viewmenu.Columns["id_menu"].Visible = false;
                dgrid_viewmenu.Columns["nama_menu"].HeaderText = "Nama Menu";
                dgrid_viewmenu.Columns["harga"].HeaderText = "Harga";
                dgrid_viewmenu.Columns["harga"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<SelectedMenuModel> selectedMenus = new List<SelectedMenuModel>();

        private void AddButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Aksi";
            btnColumn.Text = "Tambah";
            btnColumn.Name = "Tambah";
            btnColumn.UseColumnTextForButtonValue = true;
            dgrid_viewmenu.Columns.Add(btnColumn);
        }

        private void SetupPesananGrid()
        {
            // Matikan auto generate columns agar tidak konflik
            dataGridView1.AutoGenerateColumns = false;

            // Bersihkan kolom yang ada
            dataGridView1.Columns.Clear();

            // Kolom 1: Nama Menu
            DataGridViewTextBoxColumn namaMenuColumn = new DataGridViewTextBoxColumn();
            namaMenuColumn.Name = "NamaMenu"; // Nama ini harus sama dengan yang diakses nanti
            namaMenuColumn.HeaderText = "Nama Menu";
            namaMenuColumn.DataPropertyName = "NamaMenu"; // Sesuai dengan properti model
            dataGridView1.Columns.Add(namaMenuColumn);

            // Kolom 2: Harga
            DataGridViewTextBoxColumn hargaColumn = new DataGridViewTextBoxColumn();
            hargaColumn.Name = "Harga";
            hargaColumn.HeaderText = "Harga";
            hargaColumn.DataPropertyName = "Harga";
            hargaColumn.DefaultCellStyle.Format = "N0"; // Format angka
            dataGridView1.Columns.Add(hargaColumn);

            // Kolom 3: Quantity
            DataGridViewTextBoxColumn qtyColumn = new DataGridViewTextBoxColumn();
            qtyColumn.Name = "Quantity";
            qtyColumn.HeaderText = "Qty";
            qtyColumn.DataPropertyName = "Quantity";
            dataGridView1.Columns.Add(qtyColumn);

            // Kolom 4: Tombol Hapus
            DataGridViewButtonColumn hapusColumn = new DataGridViewButtonColumn();
            hapusColumn.Name = "Hapus"; // Nama ini yang akan kita cek di event click
            hapusColumn.HeaderText = "Aksi";
            hapusColumn.Text = "Hapus";
            hapusColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(hapusColumn);
        }

        private void RefreshPesananGrid()
        {
            var dataUntukDitampilkan = new List<dynamic>();

            // Loop melalui semua menu yang dipilih
            foreach (var menu in selectedMenus)
            {
                // Buat object anonymous dengan properti yang sesuai
                dataUntukDitampilkan.Add(new
                {
                    NamaMenu = menu.NamaMenu,
                    Harga = menu.Harga,
                    Quantity = menu.Quantity
                });
            }

            // Set data source grid
            dataGridView1.DataSource = null; // Reset dulu
            dataGridView1.DataSource = dataUntukDitampilkan;

            // Hitung total harga
           

        }
        private void dgrid_viewmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgrid_viewmenu.Columns["Tambah"].Index && e.RowIndex >= 0)
            {
                int idMenu = Convert.ToInt32(dgrid_viewmenu.Rows[e.RowIndex].Cells["id_menu"].Value);
                string namaMenu = dgrid_viewmenu.Rows[e.RowIndex].Cells["nama_menu"].Value.ToString();
                int harga = Convert.ToInt32(dgrid_viewmenu.Rows[e.RowIndex].Cells["harga"].Value);

                // Cek apakah menu sudah ada di list
                var existingMenu = selectedMenus.FirstOrDefault(m => m.IdMenu == idMenu);
                if (existingMenu != null)
                {
                    existingMenu.Quantity++;
                }
                else
                {
                    selectedMenus.Add(new SelectedMenuModel
                    {
                        IdMenu = idMenu,
                        NamaMenu = namaMenu,
                        Harga = harga,
                        Quantity = 1
                    });
                }

                // Refresh tampilan pesanan
                RefreshPesananGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                string namaMenu = dataGridView1.Rows[e.RowIndex].Cells["NamaMenu"].Value.ToString();
                var menuToRemove = selectedMenus.FirstOrDefault(m => m.NamaMenu == namaMenu);

                if (menuToRemove != null)
                {
                    selectedMenus.Remove(menuToRemove);
                    RefreshPesananGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservasi reservasi = new reservasi();
            reservasi.Show();
            this.Hide();
        }

        private void pilih_menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (selectedMenus.Count == 0)
            {
                MessageBox.Show("Silakan pilih menu terlebih dahulu", "Peringatan",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = MenuController.SaveOrderDetails(currentReservationId, selectedMenus);

                if (success)
                {
                    MessageBox.Show("Pesanan berhasil disimpan!", "Sukses",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pembayaran pembayaran = new pembayaran(currentReservationId);
                    pembayaran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan pesanan", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}