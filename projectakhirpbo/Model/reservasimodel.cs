using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class ReservasiModel
    {
        public int IdReservasi { get; set; }
        public string NamaCustomer { get; set; }
        public DateTime TanggalReservasi { get; set; }
        public TimeSpan WaktuReservasi { get; set; }
        public int JumlahOrang { get; set; }
        public int IdRuangan { get; set; }
        public int IdCustomer { get; set; }
    }

}