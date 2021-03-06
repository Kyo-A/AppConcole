using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class Client
    {
        private string cin;
        private string nom;
        private string prenom;
        private string tel;

        public string Cin                      //Cin en lecture seule
        {
            get { return cin; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public Client(string cin, string nom, string prenom, string tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public Client(string cin, string nom, string prenom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
        }

        public void Afficher()
        {
            Console.Out.WriteLine("CIN: " + cin);
            Console.Out.WriteLine("NOM: " + nom);
            Console.Out.WriteLine("Prénom: " + prenom);
            if (tel != "")
                Console.Out.WriteLine("Tél : " + tel);
        }
    }
}
