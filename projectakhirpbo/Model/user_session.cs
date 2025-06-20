using System;

namespace projectakhirpbo.Model
{
    public static class UserSession
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static int CurrentCustomerId { get; set; }
        public static int CurrentRole { get; set; }

        public static void ClearSession()
        {
            CurrentCustomerId = 0;
            CurrentUserId = 0;
            CurrentUsername = string.Empty;
            CurrentRole = 0;
        }
    }
}