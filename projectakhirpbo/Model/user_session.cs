using System;

namespace projectakhirpbo.Model
{
    public static class UserSession
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }

        public static void ClearSession()
        {
            CurrentUserId = 0;
            CurrentUsername = string.Empty;
        }
    }
}