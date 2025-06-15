namespace projectakhirpbo.Model
{
    public class MenuModel
    {
        private int _idmenu;
        private string _namamenu;
        private int _harga;

        public int IdMenu
        {
            get { return this._idmenu; }
            set { this._idmenu = value; }
        }
        public string NamaMenu
        {
            get { return this._namamenu; }
            set {this._namamenu = value;}
        }
        public int Harga
        {
            get { return this._harga; }
            set { this._harga = value;
        }
    }

        public class SelectedMenuModel
        {
            private int _id_menu;
            private string _nama_menu;
            private int _harga;
            private int _quantity;

            public int IdMenu
            {
                get { return this._id_menu; }
                set { this._id_menu = value; }
            }

            public string NamaMenu
            {
                get { return this._nama_menu; }
                set { this._nama_menu = value; }
            }

            public int Harga
            {
                get { return this._harga; }
                set { this._harga = value; }
            }

            public int Quantity
            {
                get { return this._quantity; }
                set { this._quantity = value; }
            }

        }
    }
}
