

namespace Requete;

class Program
{
    static void Main(string[] args)
    {
        /*Artiste artiste1 = new Artiste(1, "Ninho", 29, "Rappeur");
        Artiste artiste2 = new Artiste(2, "Jul", 30, "Rappeur");
        DAL.Ajoute(artiste2);
        Artiste artiste3 = new Artiste(3, "50 Cent", 50, "Rappeur");
        DAL.Ajoute(artiste3);
        Artiste artiste4 = new Artiste(4, "Kalti", 60, "Code");
        DAL.Ajoute(artiste4);*/
        DAL.NombreArtiste().ToConsole();
       foreach(var artiste in DAL.LesArtistes())
        {
            artiste.ToConsole();
        }



    }
}