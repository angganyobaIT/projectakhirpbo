using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class ReservasiModel
    {
        private int _idreservasi;
        private string _namacustomer; 
        public DateTime TanggalReservasi { get; set; }
        public TimeSpan WaktuReservasi { get; set; }
        public int JumlahOrang { get; set; }
        public int IdRuangan { get; set; }
        public int IdCustomer { get; set; }
        public int IdTransaksi { get; set; }

        public int IdReservasi
            {
                get { return this._idreservasi ; }
                set { this._idreservasi = value ; }
            }
        public string NamaCustomer
        {
            get { return this._namacustomer; }
            set { this._namacustomer = value; }
        }
    }
       
}