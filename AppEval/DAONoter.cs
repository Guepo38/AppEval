using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public class DAONoter
    {
        public static string selectlibE(string lib)
        {
            
            { 
                
                using (var cmd = new NpgsqlCommand("SELECT idOffre FROM OFFRE_EMPLOI WHERE titre = '" + lib + "';", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        return reader.GetString(0);
                    }
            }
            return 0;
        }

    }
}
