using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class pembayaranmodel
    {
        public int IdReservasi { get; set; }
        public int Total { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
