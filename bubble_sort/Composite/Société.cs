using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Composite
{
    public abstract class Société
    {
        protected static double coûtUnitaireVéhicule = 5.0;
        protected int nbrVéhicules;

        public void ajouteVéhicule()
        {
            nbrVéhicules = nbrVéhicules + 1;
        }

        public abstract double calculeCoûtEntretien();

        public abstract bool ajouteFiliale(Société filiale);
    }
}
