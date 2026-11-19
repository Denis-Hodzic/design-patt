using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Composite
{
    public class SociétéMère : Société
    {
        protected IList<Société> filiales = new List<Société>();

        public override bool ajouteFiliale(Société filiale)
        {
            filiales.Add(filiale);
            return true;
        }

        public override double calculeCoûtEntretien()
        {
            double coût = 0.0;
            foreach (Société soc in filiales)
                coût = coût + soc.calculeCoûtEntretien();
            return coût + nbrVéhicules * coûtUnitaireVéhicule;
        }
    }
}
