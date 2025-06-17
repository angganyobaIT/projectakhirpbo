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
using projectakhirpbo.View;
using static System.Windows.Forms.Design.AxImporter;


namespace projectakhirpbo
{
    public partial class login : Form
    {
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
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username dan password tidak boleh kosong", "Peringatan",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerId = CustomerController.ValidateCustomer(username, password);

                if (customerId > 0) // Jika ID customer valid (tidak 0)
                {
                    // Simpan informasi customer ke sesi
                    UserSession.CurrentUserId = customerId;
                    UserSession.CurrentUsername = username;

                    // Tampilkan pesan sukses
                    MessageBox.Show($"Selamat datang, {username}!", "Login Sukses",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Buka form utama
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah", "Autentikasi Gagal",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}    