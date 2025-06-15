using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    class detailreservasimodel
    {
        public int IdMenu { get; set; }
        public string NamaMenu { get; set; }
        public int Kuantitas { get; set; } = 1; // Default 1
        public int Harga { get; set; }
        public int TotalHarga => Kuantitas * Harga;
    }
}

