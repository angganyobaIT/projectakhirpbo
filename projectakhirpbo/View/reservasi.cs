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
   
        public reservasi()
        {
            InitializeComponent();
        
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
           
            
        }
       

        private void Meja_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
