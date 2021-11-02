using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public abstract class Vehicule
    {
        public int Matricule { get; }
        public string Modele { get; set; }
        public double Prix { get; set; }
        public static int nbrVehicule { get; set; }
        protected Vehicule(int matricule, string modele, double prix)
        {
            Matricule = matricule;
            Modele = modele;
            Prix = prix;
            nbrVehicule++;
        }
        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return "Matricule: " + Matricule + "Modele :" + Modele + "Prix :" + Prix;
        }

    }
}
