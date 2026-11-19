using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Composite
{
    public class SociétéSansFiliale : Société
    {
        public override bool ajouteFiliale(Société filiale)
        {
            return false;
        }

        public override double calculeCoûtEntretien()
        {
            return nbrVéhicules * coûtUnitaireVéhicule;
        }
    }
}
