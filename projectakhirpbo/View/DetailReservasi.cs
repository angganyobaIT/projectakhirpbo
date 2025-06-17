using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using projectakhirpbo.Controller;

namespace projectakhirpbo.View
{
    public partial class DetailReservasi : Form
    {
        private readonly int _ID_reservasi;
        public DetailReservasi(int ID_reservasi)
        {
            _ID_reservasi = ID_reservasi;
            InitializeComponent();
        }

        private void DetailReservasi_Load(object sender, EventArgs e)
        {
            var detailList = DetailReservasiAdmin.get_detail_reservasi(_ID_reservasi);
            dataGridView1.DataSource = detailList;
            dataGridView1.Columns["id_detail_reservasi"].Visible = false;
            dataGridView1.Columns["id_reservasi"].Visible = false;
            string sql2 = @"select sum(kuantitas_menu * b.harga)
from detail_reservasi a
join menu b using (id_menu)";
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql2, conn))
                    {
                        int TOTAL = Convert.ToInt32(cmd.ExecuteScalar());
                        LB_total.Text = TOTAL.ToString();
                    }
                }
                catch (Exception ex)
                {
                    LB_total.Text = "Error: " + ex.Message;
                }
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
