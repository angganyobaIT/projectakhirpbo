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
    public partial class EditReservasi : Form
    {
        private int id_reservasi;
        public EditReservasi(string nama, string no_telp, DateTime tanggal, TimeSpan waktu, int jumlah, string ruang, int id_reservasi)
        {
            InitializeComponent();
            tb_namacustomer.Text = nama;
            tb_telp_customer.Text = no_telp;
            reserv_date.Value = tanggal;
            reserv_time.Items.Add(waktu.ToString(@"hh\:mm"));
            reserv_time.SelectedItem = waktu.ToString(@"hh\:mm");
            jumlah_orang.Value = jumlah;
            cb_pilihanruangan.SelectedItem = ruang;
            this.id_reservasi = id_reservasi;

        }

        private void EditReservasi_Load(object sender, EventArgs e)
        {

        }

        private void reserv_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reserv_time_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_namacustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_telp_customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void jumlah_orang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_pilihanruangan_SelectedIndexChanged(object sender, EventArgs e)
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

            // Konversi waktu ke TimeSpan
            if (!TimeSpan.TryParse(reserv_time.SelectedItem.ToString(), out TimeSpan waktu))
            {
                MessageBox.Show("Format waktu tidak valid", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Konversi pilihan ruangan ke ID (1 untuk Indoor, 2 untuk Outdoor)
            int idRuangan = cb_pilihanruangan.SelectedItem.ToString() == "Indoor" ? 1 : 2;

            var reservasi = new ReservasiModel
            {
                IdReservasi = id_reservasi,
                NamaCustomer = tb_namacustomer.Text,
                No_telp = tb_telp_customer.Text,
                TanggalReservasi = reserv_date.Value,
                WaktuReservasi = waktu,
                JumlahOrang = (int)jumlah_orang.Value,
                IdCustomer = UserSession.CurrentUserId,
                IdRuangan = idRuangan,
            };

            bool berhasil = ReservasiController.UpdateReservasi(reservasi);
            if (berhasil)
            {
                MessageBox.Show("Reservasi berhasil diperbarui.", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui reservasi. Silakan coba lagi.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
