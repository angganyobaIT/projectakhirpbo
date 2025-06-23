using projectakhirpbo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    public class CustomerUser : User
    {
        public int CustomerId { get; }

        public CustomerUser(int id, string username, int customerId)
            : base(id, username)
        {
            CustomerId = customerId;
        }

        public override void ShowHomepage()
        {
            var home = new Homepage();
            home.Show();
        }
    }
}
