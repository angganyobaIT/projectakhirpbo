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
    }
}
