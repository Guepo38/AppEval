using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public class ConnexionDB
    {
        public static NpgsqlConnection CoDB()
        {
            string db = "Host=localhost;Username=postgres;Password=;Database=AppEval";

            NpgsqlConnection connexionDB = new NpgsqlConnection(db);
            connexionDB.Open();

            return connexionDB;
        }
    }
}
