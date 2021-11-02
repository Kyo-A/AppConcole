using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Exceptions
{
    public class IncorrectStreetNameException : Exception
    {
        public IncorrectStreetNameException(string rue)
            : base("Le nom de la rue " + rue + " doit etre en majuscule !")
        {

        }
    }
}
