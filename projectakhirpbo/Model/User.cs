using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public abstract class User
    {
        public int Id { get; }
        public string Username { get; }

        protected User(int id, string username)
        {
            Id = id;
            Username = username;
        }

        // Metode abstrak—harus diimplementasi di subclass
        public abstract void ShowHomepage();
    }
}
