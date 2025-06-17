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
    public partial class reservasi : Form
    {
        public static class ReservasiSession
        {
            public static int CurrentReservasiId { get; set; }
        }

        public reservasi()
        {
            InitializeComponent();
            reserv_date.MinDate = DateTime.Today;
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
          
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void reservasi_Load(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void cbmeja10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lanjutkan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_namacustomer.Text) ||
               reserv_time.SelectedIndex == -1 ||
               cb_pilihanruangan.SelectedIndex == -1)
            {
                MessageBox.Show("Harap isi semua data!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pastikan customer sudah login
            if (UserSession.CurrentUserId == 0)
            {
                MessageBox.Show("Silakan login terlebih dahulu!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konversi waktu ke TimeSpan
            if (!TimeSpan.TryParse(reserv_time.SelectedItem.ToString(), out TimeSpan waktu))
            {
                MessageBox.Show("Format waktu tidak valid", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Konversi pilihan ruangan ke ID (1 untuk Indoor, 2 untuk Outdoor)
            int idRuangan = cb_pilihanruangan.SelectedItem.ToString() == "Indoor" ? 1 : 2;

            // Buat objek reservasi
            //var reservasi = new ReservasiModel
            //{
            //    NamaCustomer = tb_namacustomer.Text,
            //    TanggalReservasi = reserv_date.Value,
            //    WaktuReservasi = waktu,
            //    JumlahOrang = (int)jumlah_orang.Value,
            //    IdRuangan = idRuangan,
            //    IdCustomer = UserSession.CurrentUserId // Menggunakan ID dari session
            //};
            var pembayaran = new pembayaranmodel
            {
                waktu_pembayaran = DateTime.Now
            };

            try
            {
                // Simpan ke database
                int idTransaksi = ReservasiController.Transaksi(pembayaran);
                if (idTransaksi <= 0)
                {
                    // Gagal simpan transaksi
                    return;
                }
                //bool sukses = ReservasiController.transaksi(pembayaran);

                var reservasi = new ReservasiModel
                {
                    NamaCustomer = tb_namacustomer.Text,
                    TanggalReservasi = reserv_date.Value,
                    WaktuReservasi = waktu,
                    JumlahOrang = (int)jumlah_orang.Value,
                    IdCustomer = UserSession.CurrentUserId,
                    IdRuangan = idRuangan,
                    IdTransaksi = idTransaksi
                };

                // 3. Simpan reservasi
                int idReservasi = ReservasiController.BuatReservasi(reservasi);
                if (idReservasi > 0)
                {
                    MessageBox.Show($"Reservasi berhasil! ID: {idReservasi}");
                }
                else
                {
                    MessageBox.Show("Gagal membuat reservasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //int idReservasi = ReservasiController.BuatReservasi(reservasi);

                if (idReservasi > 0)
                {
                    // Simpan ID reservasi untuk proses selanjutnya
                    ReservasiSession.CurrentReservasiId = idReservasi;

                    // Tampilkan notifikasi sukses
                    MessageBox.Show("Reservasi berhasil dibuat!", "Sukses",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pilih_menu pilihMenuForm = new pilih_menu(idReservasi,idTransaksi);
                    pilihMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal membuat reservasi.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void Meja_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
