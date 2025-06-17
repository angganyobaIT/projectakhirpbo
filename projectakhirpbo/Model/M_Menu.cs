using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class M_Menu : M_Kategori
    {

        public int id_menu { get; set; }
        public string nama_menu { get; set; }
        public int harga { get; set; }
        public int Dihapus { get; set; }
        public int id_kategori { get; set; }
        public string nama_kategori { get; set; }


    }
}