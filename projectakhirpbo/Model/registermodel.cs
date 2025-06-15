using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    class registermodel
    {
        private string _username;
        private string _password;
        private string _email;

        public string username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        public string password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }
    }
}

