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
    public partial class historireservasi : Form
    {
        public historireservasi()
        {
            InitializeComponent();
        }

        private void homepagebtn_Click(object sender, EventArgs e)
        {
            //Homepage homepage = new Homepage();
            //homepage.Show();
            //this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void historireservasi_Load(object sender, EventArgs e)
        {
            List<ReservasiModel> resev = UserController.Get_Resev_history(UserSession.CurrentUserId);
            dataGridView1.DataSource = resev;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Columns["IdReservasi"].Visible = false;
            dataGridView1.Columns["IdCustomer"].Visible = false;
            dataGridView1.Columns["IdRuangan"].Visible = false;
            dataGridView1.Columns["IdTransaksi"].Visible = false;
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void BTN_LihaResev_Click(object sender, EventArgs e)
        {
            LihatReservasi resev = new LihatReservasi();
            resev.Show();
            this.Hide();
        }

        private void BTN_Profil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            this.Close();
        }
    }
}
