using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class M_ReservasiAdmin
    {
        public int id_reservasi { get; set; }
        public string nama_lengkap { get; set; }
        public DateTime tanggal_kedatangan { get; set; }
        public TimeSpan waktu_kedatangan { get; set; }
        public string status_reservasi { get; set; }
        //ruangan
        public int id_ruangan { get; set; }
        public string jenis_ruangan { get; set; }
        //transaksi
        public int id_transaksi { get; set; }
        public string status_pembayaran { get; set; }
        public DateTime waktu_pembayaran { get; set; }
    }
}