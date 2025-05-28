using Npgsql;
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

namespace projectakhirpbo
{
    public partial class login : Form
    {
        Customer user = new Customer();
        Customer_Contex customer_Contex = new Customer_Contex();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register Register = new register();
            Register.Show();
            this.Hide();
        }

        private void btnmasuk_Click(object sender, EventArgs e)
        {
            string username = tbusernamelog.Text.Trim();
            string password = tbpasswordlog.Text.Trim();

            try
            {
                var ctx = new Customer_Contex();
                bool ngecek = ctx.Validasi(username, password, out int customerId);

                if (ngecek)
                    MessageBox.Show($"Login berhasil! ID: {customerId}");
                else
                    MessageBox.Show("Username atau password salah.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
