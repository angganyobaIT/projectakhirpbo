using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    class reservasimodel
    {
        public int id_reservasi { get; set; }
        public TimeSpan waktuReservasi { get; set; } // time
        public DateTime tanggalReservasi { get; set; } // date
        public string namaCustomer { get; set; }
        public string noTeleponCustomer { get; set; }
        public int jumlahOrang { get; set; }
        public int meja { get; set; }
    }
}

