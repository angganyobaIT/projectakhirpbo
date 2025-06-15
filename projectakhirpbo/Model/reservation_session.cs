using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirpbo.Model
{
    class reservation_session
    {
        public static int CurrentReservid { get; set; } = 0;

        public static void ClearSession()
        {
            CurrentReservid = 0;
        }
    }
}
