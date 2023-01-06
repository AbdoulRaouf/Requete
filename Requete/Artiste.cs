using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requete
{
    internal class Artiste
    {
        public int ArtisteId { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }

        public Artiste(int id,string nom, int age, string profession)
        {
            ArtisteId = id;
            Nom = nom;
            Age = age;
            Profession = profession;
        }
        public Artiste() { }
        public override string ToString()
        {
            return $"id= {ArtisteId} , Nom= {Nom}, Age= {Age}, profession= {Profession}";
        }
    }
}
