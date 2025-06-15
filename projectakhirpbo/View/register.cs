using System;
using Microsoft.VisualBasic.ApplicationServices;
using projectakhirpbo.Controller;
using projectakhirpbo.Model;
using Npgsql;
using projectakhirpbo.View;

namespace projectakhirpbo
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbusername.Text) ||
       string.IsNullOrWhiteSpace(tbemail.Text) ||
       string.IsNullOrWhiteSpace(tbpassword.Text) ||
       string.IsNullOrWhiteSpace(tbconfirmpass.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi username unik
            if (UserController.IsUsernameExists(tbusername.Text.Trim()))
            {
                MessageBox.Show("Username sudah digunakan!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi email
            string email = tbemail.Text.Trim().ToLower();
            if (!(email.EndsWith("@gmail.com") && !(email.EndsWith("@yahoo.com"))))
            {
                MessageBox.Show("Hanya email @gmail.com atau @yahoo.com yang diterima!",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi password
            if (tbpassword.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbpassword.Text != tbconfirmpass.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak cocok!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buat objek customer baru
            Customer newCustomer = new Customer
            {
                Username = tbusername.Text.Trim(),
                Email = tbemail.Text.Trim(),
                Password = tbpassword.Text // Dalam real app, password harus di-hash
            };

            // Simpan ke database
            if (UserController.RegisterCustomer(newCustomer))
            {
                MessageBox.Show("Registrasi berhasil!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                login loginForm = new login();
                loginForm.Show();
                this.Hide();
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login Login = new login();
            Login.Show();
            this.Hide();
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

            tbpassword.PasswordChar = '*';
            tbconfirmpass.PasswordChar = '*';
        }


        private void checkshow1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshow1.Checked)
            {
                tbpassword.PasswordChar = '\0';
            }
            else
            {
                tbpassword.PasswordChar = '*';
            }
        }

        private void checkshow2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshow2.Checked)
            {
                tbconfirmpass.PasswordChar = '\0';
            }
            else
            {
                tbconfirmpass.PasswordChar = '*';
            }
        }

        private void tbconfirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void btnshow1_Click(object sender, EventArgs e)
        //{
        //    // Toggle password visibility
        //    if (tbpassword.PasswordChar == '*')
        //    {
        //        tbpassword.PasswordChar = '\0'; // Show password
        //    }
        //    else
        //    {
        //        tbpassword.PasswordChar = '*'; // Hide password
        //    }
        //}

    }
}
