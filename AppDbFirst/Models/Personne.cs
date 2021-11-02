using System;
using System.Collections.Generic;

#nullable disable

namespace AppDbFirst.Models
{
    public partial class Personne
    {
        public int Num { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Budget { get; set; }

        public Personne(string nom, string prenom, int budget)
        {
            Nom = nom;
            Prenom = prenom;
            Budget = budget;
        }

        public override string ToString()
        {
            return $"{Num} + {Nom} + {Prenom} + {Budget}";
        }
    }
}
