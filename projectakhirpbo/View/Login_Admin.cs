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
using static System.Collections.Specialized.BitVector32;

namespace projectakhirpbo.View
{
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            try
            {
                var ctx = new AdminLoginController();
                bool ngecek = ctx.Validasi_admin(username, password, out int adminId);

                if (ngecek)
                {
                    UserSession.CurrentUserId = adminId;
                    UserSession.CurrentUsername = username;

                    MessageBox.Show($"Login berhasil! Selamat datang: {username}");
                    HomepageAdmin home = new HomepageAdmin();
                    home.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username atau password salah.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
