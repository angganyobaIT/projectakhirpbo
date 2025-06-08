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
        private customer currentCustomer;
        public reservasi(customer customer)
        {
            InitializeComponent();
            this.currentCustomer = customer;
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

        }

        private void cbmeja10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lanjutkan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_namacustomer.Text) ||
        string.IsNullOrWhiteSpace(reserv_time.Text) ||
        string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
        string.IsNullOrWhiteSpace(no_telp_customer.Text) ||
        string.IsNullOrWhiteSpace(jumlah_orang.Text))
            {
                MessageBox.Show("Pastikan semua kolom telah terisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            reservasimodel reserv = new reservasimodel();
            reserv.namaCustomer = tb_namacustomer.Text;
            reserv.noTeleponCustomer = no_telp_customer.Text;
            reserv.tanggalReservasi = dateTimePicker1.Value.Date;
            reserv.waktuReservasi = TimeSpan.Parse(reserv_time.Text); // Format harus sesuai
            reserv.jumlahOrang = int.Parse(jumlah_orang.Text);
            reserv.meja = GetNomorMeja(); // Implementasikan fungsi ini di bawah

            bool result = reservasicontroller.Reservasi(reserv, currentCustomer);
            if (result)
            {
                MessageBox.Show("Reservasi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private int GetNomorMeja()
        {
            if (meja1.Checked) return 1;
            if (meja2.Checked) return 2;
            if (meja3.Checked) return 3;
            if (meja4.Checked) return 4;
            if (meja5.Checked) return 5;
            if (meja6.Checked) return 6;
            if (meja7.Checked) return 7;
            if (meja8.Checked) return 8;
            if (meja9.Checked) return 9;
            if (meja10.Checked) return 10;
            return 0; // Jika tidak ada yang dipilih
        }

        private void Meja_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
