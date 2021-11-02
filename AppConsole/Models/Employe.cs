using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class Employe
    {
        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateEmbauche { get; set; }
        public double Salaire { get; set; }
        public static int nbrEmployes { get; set; }

        //private int matricule;
        //private string nom;
        //private string prenom;
        //private DateTime dateNaissance;
        //private DateTime dateEmbauche;
        //private double salaire;

        //public int Matricule { get => matricule; set => matricule = value; }
        //public string Nom { get => nom; set => nom = value; }
        //public string Prenom { get => prenom; set => prenom = value; }
        //public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        //public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        //public double Salaire { get => salaire; set => salaire = value; }

        public Employe()
        {
            nbrEmployes++;
        }
        public Employe(int matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, double salaire)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.DateEmbauche = dateEmbauche;
            this.Salaire = salaire;
            nbrEmployes++;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - DateNaissance.Year;
            return age;
        }

        public void AfficheEmploye()
        {
            Console.WriteLine($"\n\n  Matricule : {Matricule} ");
            Console.WriteLine("Nom Complet : " + Nom.ToUpper() + " " + Prenom.Substring(0, 1).ToUpper());
            Console.WriteLine("Age :" +  Age() );

        }

    }
}
