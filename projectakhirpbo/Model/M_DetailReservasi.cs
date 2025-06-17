using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class M_DetailReservasi
    {
        public int id_detail_reservasi { get; set; }
        public int kuantitas_menu { get; set; }
        //menu
        public string nama_menu { get; set; }
        public int harga { get; set; }
        public int subtotal { get; set; }
        //resev
        public int id_reservasi { get; set; }
    }
}