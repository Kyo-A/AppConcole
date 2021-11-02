using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    public class ListePersonnes : IEnumerable<Personne>
    {
        private int nbrPersonnes;
        private Personne[] Personnes;
        public ListePersonnes(int i)
        {
            Personnes = new Personne[i];
            nbrPersonnes = 0;
        }
        public int NbrPersonnes
        {
            get => nbrPersonnes;
            set => nbrPersonnes = value;
        }
        public Personne this[int i]
        {
            get { return Personnes[i]; }
            set { Personnes[i] = value; nbrPersonnes++; }
        }

        public IEnumerator<Personne> GetEnumerator()
        {
            return ((IEnumerable<Personne>)Personnes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Personnes.GetEnumerator();
        }
    }
}
