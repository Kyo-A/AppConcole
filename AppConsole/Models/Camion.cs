using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class Camion : Vehicule
    {
        public Camion(int matricule, string modele, double prix) : base(matricule, modele, prix) { }
        public override void Accelerer()
        {
            Console.WriteLine("le camion accelere !");
        }

        public override void Demarrer()
        {
            Console.WriteLine("le camion demarre !");
        }
        public override string ToString()
        {
            return "Camion " + base.ToString();
        }
    }
}