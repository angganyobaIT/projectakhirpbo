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
        private static string password = "chacha10";
        private static string database = "PBO_PRO3";

        public static NpgsqlConnection GetConnection()
        {
            string connString = $"Host={localhost};Port={port};Username={username};Password={password};Database={database}";
            return new NpgsqlConnection(connString);
        }
    }
}
