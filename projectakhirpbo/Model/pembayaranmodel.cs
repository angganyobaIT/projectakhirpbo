using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class pembayaranmodel
    {
        private int _idreservasi { get; set; }
        private int _total { get; set; }
        private string _status { get; set; }

        public DateTime waktu_pembayaran { get; set; }

        public int IdReservasi
        {
            get{ return this._idreservasi; }
            set { this._idreservasi = value; }
        }

        public int Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        public string Status
        {
            get { return this._status; }
            set {  this._status = value; }
        }

        
    }
}
