using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Exceptions
{
    public class IncorrectCodePostalException : Exception
    {
        public IncorrectCodePostalException() 
            : base("Le code postal doit contenir exactement 5 chiffres !")
        {

        }
    }
}
