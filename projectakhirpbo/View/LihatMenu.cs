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
    public partial class LihatMenu : Form
    {
        
        public LihatMenu()
        {
            InitializeComponent();
        }

        private void LihatMenu_Load(object sender, EventArgs e)
        {
            List<M_Menu> menus = MenuAdminController.get_menu();
            dataGridView1.DataSource = menus;
            dataGridView1.Columns["id_menu"].Visible = false;
            dataGridView1.Columns["id_kategori"].Visible = false;
            dataGridView1.Columns["Dihapus"].Visible = false;
        }

        private void BTN_Makanan_Click(object sender, EventArgs e)
        {
            LihatMakananSaja makan = new LihatMakananSaja();
            makan.Show();
            this.Hide();
        }

        private void BTN_Minuman_Click(object sender, EventArgs e)
        {
            LihatMinuman minum = new LihatMinuman();
            minum.Show();
            this.Hide();
        }

        private void BTN_Cemilan_Click(object sender, EventArgs e)
        {
            LihatCemilan cemilan = new LihatCemilan();
            cemilan.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }
    }
}
