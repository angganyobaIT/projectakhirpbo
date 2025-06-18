using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectakhirpbo.Model;

namespace projectakhirpbo.View
{

    public partial class Homepage : Form
    {
        //private int currentReservationId; int currentReservationId
        public Homepage()
        {
            InitializeComponent();
            //this.currentReservationId = currentReservationId;
        }

        private void btnreservasi_Click(object sender, EventArgs e)
        {
            reservasi reservasi = new reservasi();
            reservasi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            this.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LihatMinuman minum = new LihatMinuman();
            minum.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LihatReservasi reservasi = new LihatReservasi();
            reservasi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void btnallmenu_Click(object sender, EventArgs e)
        {
            LihatMenu menu = new LihatMenu();
            menu.Show();
            this.Hide();
        }

        //private void btnmakanan_Click(object sender, EventArgs e)
        //{
        //    LihatMakananSaja makan = new LihatMakananSaja();
        //    makan.Show();
        //    this.Hide();
        //}

        //private void btncemilan_Click(object sender, EventArgs e)
        //{
        //    LihatCemilan cemilan = new LihatCemilan();
        //    cemilan.Show();
        //    this.Hide();
        //}

        private void btnmakanan_Click_1(object sender, EventArgs e)
        {
            LihatMakananSaja makan = new LihatMakananSaja();
            makan.Show();
            this.Hide();
        }

        private void btncemilan_Click_1(object sender, EventArgs e)
        {
            LihatCemilan cemilan = new LihatCemilan();
            cemilan.Show();
            this.Hide();
        }
    }
}
