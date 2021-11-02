using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Tests
{
    public class Calcul
    {
        ICalculService calculService;

        public Calcul(ICalculService _calculService)
        {
            calculService = _calculService;
        }

        public int SommeCarre(int x, int y)
        {
            return Somme(calculService.Carre(x), calculService.Carre(y));
        }

        public int SommeAddTwo(int x, int y)
        {
            return Somme(calculService.AddTwo(x), calculService.AddTwo(y));
        }

        public int Somme(int x, int y)
        {
            return x + y;
        }

        public int Division(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }
        public int Soustraction(int x, int y)
        {
            return x - y;
        }
    }
}
