using System;
using System.Windows.Forms;
using Npgsql;
using projectakhirpbo.Controller;
using projectakhirpbo.Model;


namespace projectakhirpbo.View
{
    public partial class pembayaran : Form
    {
        private int idReservasi;
        private pembayaranmodel dataPembayaran;
        public pembayaran(int reservationId)
        {
            InitializeComponent();
            this.idReservasi = reservationId;
            SiapkanPembayaran();
            TampilkanTotal();
        }
        private void SiapkanPembayaran()
        {
            dataPembayaran = new pembayaranmodel
            {
                IdReservasi = idReservasi,
                Total = pembayarancontroller.HitungTotal(idReservasi),
                Status = "Pending"
            };
        }

        private void TampilkanTotal()
        {
            // Tampilkan total di label atau textbox
            totallbl.Text = $"Total: Rp {dataPembayaran.Total:N0}";
        }

        private void LoadPaymentData()
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {

        }

        private void pembayaran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pembayarancontroller.ProsesPembayaran(dataPembayaran))
            {
                MessageBox.Show("Pembayaran berhasil!", "Sukses");
                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal memproses pembayaran", "Error");
            }
        }

        private void totallbl_Click(object sender, EventArgs e)
        {

        }
    }
}