using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requete
{
    internal class DAL1
    {
        private NpgsqlConnection ObjetDeConnexion()
        {
            return new NpgsqlConnection("User ID=postgres;Password=121225033;Host=localhost;Port=5432;Database=ArtisteDataBase;");
        }

    }
}
