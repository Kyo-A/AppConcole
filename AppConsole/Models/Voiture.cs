using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class Voiture : Vehicule
    {
        public Voiture(int matricule, string modele, double prix) :base(matricule, modele, prix) { }
        public override void Accelerer()
        {
            Console.WriteLine("la voiture accelere !");
        }

        public override void Demarrer()
        {
            Console.WriteLine("la voiture demarre !");
        }
        public override string ToString()
        {
            return "Voiture " + base.ToString();
        }
    }
}
