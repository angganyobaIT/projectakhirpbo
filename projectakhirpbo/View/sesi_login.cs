using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectakhirpbo.Model;

namespace projectakhirpbo.View
{
    class sesi_login
    {
        public static class ReservasiSession
        {
            public static int CurrentReservasiId { get; set; }
        }

        public static class UserSession
        {
            public static Customer CurrentCustomer { get; set; }
        }
    }
}
