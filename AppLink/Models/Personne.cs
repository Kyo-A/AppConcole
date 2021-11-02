using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLink.Models
{
    [Table("personnes")]
    public class Personne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
