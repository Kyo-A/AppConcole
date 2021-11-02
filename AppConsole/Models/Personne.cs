using AppConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class Personne : ISalutation, IGreetings
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Personne()
        {
        }
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public virtual void direBonjour()
        {
            Console.WriteLine("Bonjour {0} {1}", Prenom, Nom);
        }

        public void sayHello()
        {
            Console.WriteLine("Hello {0} {1}", Prenom, Nom);
        }
    }
}
