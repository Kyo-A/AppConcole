using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public struct Livre
    {
        public string isbn;
        public string titre;
        public int nbrPages;

        public void AfficherDetails()
        {
            Console.WriteLine($" Isbn : {isbn} \n Titre {titre} \n Nombre de pages : {nbrPages}");
        }
    }
}
