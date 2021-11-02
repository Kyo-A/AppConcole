using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class Etudiant : Personne
    {
        public int Bourse { get; set; }

        public Etudiant(string nom, string prenom, int bourse) : base( nom, prenom)
        {
            this.Bourse = bourse;
        }

        // Pour redefinir une methode recupere d'une classe mere, utiliser le mot cle new
        public override void direBonjour()
        {
            Console.WriteLine("Bonjour l'etudiant {0} {1}", Prenom, Nom);
        }
    }
}
