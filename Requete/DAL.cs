using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requete;

internal class DAL
{
    private static NpgsqlConnection ObjetDeConnexion()
    {
        return new NpgsqlConnection("User ID=postgres;Password=121225033;Host=localhost;Port=5432;Database=ArtisteDataBase;");
    }
    public static void Ajoute(Artiste artiste)
    {
        NpgsqlConnection connection = ObjetDeConnexion();
        try
        {
            connection.Open();

            string rsql = "insert into artiste values(@id,@nom,@age,@profession)";

            NpgsqlCommand command = new(rsql, connection);
            command.Parameters.AddWithValue("@nom", artiste.Nom);
            command.Parameters.AddWithValue("@id", artiste.ArtisteId);
            command.Parameters.AddWithValue("@age", artiste.Age);
            command.Parameters.AddWithValue("@profession", artiste.Profession);
            command.ExecuteNonQuery();
            "OK".ToConsole();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally { connection.Close(); }
    }



    public static Int64 NombreArtiste()
    {
        NpgsqlConnection connection = ObjetDeConnexion();
        try
        {
            connection.Open();

            string rsql = "select count(*) from artiste";

            NpgsqlCommand command = new(rsql, connection);

            return (Int64)command.ExecuteScalar();

            "OK".ToConsole();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return -1;
        }
        finally { connection.Close(); }
    }
    public static List<Artiste> LesArtistes()
    {
        List<Artiste> artistesList= new List<Artiste>();
        NpgsqlConnection connection = ObjetDeConnexion();
        try
        {
            connection.Open();

            string rsql = "select * from artiste";

            NpgsqlCommand command = new(rsql, connection);

            NpgsqlDataReader dataReader= command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    Artiste artiste = new Artiste
                    {
                        ArtisteId = int.Parse(dataReader["artiste_id"].ToString()),
                        Nom = dataReader["nom"].ToString(),
                        Age = int.Parse(dataReader["age"].ToString()),
                        Profession = dataReader["age"].ToString()

                    };
                    artistesList.Add(artiste);
                }
                dataReader.Close();
            }
            return artistesList;
            

            "OK".ToConsole();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Enumerable.Empty<Artiste>().ToList();
        }
        finally { connection.Close(); }
    }

}


public static class StringExtension
{
    public static void ToConsole(this object str) => Console.WriteLine(str);
    //"fd".ToConsole();
}