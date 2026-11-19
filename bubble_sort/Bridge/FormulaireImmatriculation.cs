using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Bridge
{
    public class FormulaireImmatriculation
    {
        protected string contenue;
        protected IFormulaireLmpl implementaion;


        public FormulaireImmatriculation(IFormulaireLmpl implementaion)
        {
            this.implementaion = implementaion;
        }

        public void affiche()
        {
            implementaion.dessineTexte();
        }

        public void genereDocument()
        {
            Console.WriteLine("Générè le document");
        }

        public void gereSaisie()
        {
            implementaion.gereZoneSaisie();
        }

        protected virtual void contrôleSaisie()
        {
            Console.WriteLine("Controle de la saisie");
        }

    }
}
