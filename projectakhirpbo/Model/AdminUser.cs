using projectakhirpbo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class AdminUser : User
    {
        public AdminUser(int id, string username)
            : base(id, username) { }

        public override void ShowHomepage()
        {
            var home = new HomepageAdmin();
            home.Show();
        }
    }
}
