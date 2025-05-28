using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class Customer
    {
        private int id_customer;
        private string username;
        private string password;
        private string email;

        public int Id_customer
        {
            get { return this.id_customer; }
            set { this.id_customer = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
