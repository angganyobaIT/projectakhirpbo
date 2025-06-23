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
            var username = tbusernamelog.Text.Trim();
            var password = tbpasswordlog.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // out-parameters akan terisi kalau login berhasil
                if (UserController.ValidateLogin(
                        username, password,
                        out var akunId,
                        out var roleId,
                        out var customerId))
                {
                    // Simpan ke session
                    UserSession.CurrentUserId = akunId;
                    UserSession.CurrentUsername = username;
                    UserSession.CurrentRole = roleId;
                    UserSession.CurrentCustomerId = customerId?? 0;

                    MessageBox.Show($"Selamat datang, {username}!", "Login Sukses",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Arahkan sesuai role
                    if (roleId == 1)
                    {
                        new HomepageAdmin().Show();
                    }
                    else if (roleId == 2)
                    {
                        // kalau form UserHomepage butuh ID_customer:
                        var userHome = new Homepage();
                        userHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("Role tidak dikenali.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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

    }
}    