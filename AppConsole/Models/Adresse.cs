using AppConsole.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class Adresse
    {
        public string Rue { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public Adresse(string rue, string ville, string codePostal)
        {
            if (codePostal.Length != 5)
                throw new IncorrectCodePostalException();
            if (!rue.Equals(rue.ToUpper()))
                throw new IncorrectStreetNameException(rue);
            Rue = rue;
            Ville = ville;
            CodePostal = codePostal;
        }
    }
}
