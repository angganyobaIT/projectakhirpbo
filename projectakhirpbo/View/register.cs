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
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbusername.Text) ||
                string.IsNullOrWhiteSpace(tbemail.Text) ||
                string.IsNullOrWhiteSpace(tbpassword.Text) ||
                string.IsNullOrWhiteSpace(tbconfirmpass.Text))
            {
                MessageBox.Show("Pastikan semua kolom telah terisi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cek username sudah digunakan
            int found = 0;
            NpgsqlConnection conn = Database.GetConnection();
            conn.Open();
            string query = "SELECT username FROM customer";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (tbusername.Text == reader.GetString(0))
                    {
                        found = 1;
                        break;
                    }
                }
            }
            conn.Close();

            if (found == 1)
            {
                MessageBox.Show($"Username {tbusername.Text} sudah pernah digunakan sebelumnya", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validasi password
            if (tbpassword.Text.Length < 8)
            {
                MessageBox.Show("Password harus terdiri dari minimal 8 karakter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbpassword.Text != tbconfirmpass.Text)
            {
                MessageBox.Show("Password dan konfirmasi tidak cocok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi email
            string email = tbemail.Text.ToLower();
            if (!(email.EndsWith("@gmail.com") || email.EndsWith("@yahoo.com")))
            {
                MessageBox.Show("Email harus menggunakan domain Gmail atau Yahoo", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
