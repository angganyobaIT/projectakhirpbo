using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace projectakhirpbo
{
    public class Database
    {
        private static string localhost = "localhost";
        private static string port = "5432";
        private static string username = "postgres";
        private static string password = "Postgresql31_";
        private static string database = "pbo_finaltask";

        private static NpgsqlConnection conn;

        public static NpgsqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connString = $"Host={localhost};Port={port};Username={username};Password={password};Database={database}";
                conn = new NpgsqlConnection(connString);
            }
            return conn;
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
