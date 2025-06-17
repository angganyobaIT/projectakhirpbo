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
        private int id_transaksi;
        private pembayaranmodel dataPembayaran;
        public pembayaran(int reservationId,int transaksi_id)
        {
            InitializeComponent();
            this.idReservasi = reservationId;
            this.id_transaksi = transaksi_id;
            SiapkanPembayaran();
            TampilkanTotal();
        }
        private void SiapkanPembayaran()
        {
            dataPembayaran = new pembayaranmodel
            {
                IdReservasi = idReservasi,
                Total = pembayarancontroller.HitungTotal(idReservasi),
                id_transaksi = id_transaksi
                //Status = "Pending"
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
            bool sukses = pembayarancontroller.ProsesPembayaran(dataPembayaran);
            if (sukses)
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