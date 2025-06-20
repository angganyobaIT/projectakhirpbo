using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectakhirpbo.Model;
using projectakhirpbo.Controller;

namespace projectakhirpbo.View
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
            tbCPassword.UseSystemPasswordChar = true;
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            // Load username & email
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                const string query =
                    "SELECT username, email FROM Customer WHERE ID_customer = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", UserSession.CurrentUserId);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            tbUsername.Text = rdr.GetString(rdr.GetOrdinal("username"));
                            tbEmail.Text = rdr.GetString(rdr.GetOrdinal("email"));
                        }
                    }
                }
            }
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

        private void BTN_simpan_Click(object sender, EventArgs e)
        {
            string newUsername = tbUsername.Text.Trim();
            string newEmail = tbEmail.Text.Trim();
            string newPassword = tbPassword.Text;
            string confirmPassword = tbCPassword.Text;

            // Validasi kosong
            if (string.IsNullOrEmpty(newUsername) ||
                string.IsNullOrEmpty(newEmail) ||
                string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Semua field wajib diisi.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi email sederhana
            if (!Regex.IsMatch(newEmail,
                   @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Format email tidak valid.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi password match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Password dan konfirmasi tidak sama.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool berhasil = UserController.update_user(newUsername, newEmail, newPassword, UserSession.CurrentUserId);
            if (berhasil)
            {
                MessageBox.Show("Data Berhasil Dihapus Silahkan Refresh", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BTN_Profil_Click(object sender, EventArgs e)
        {
            Profil refresh = new Profil();
            refresh.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            this.Close();
        }
    }
}
