using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Bridge
{
    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(IFormulaireLmpl implementaion) : base(implementaion) { }

        protected override void contrôleSaisie()
        {
            Console.WriteLine("Contrôle de la saisie pour la France");
        }
    }
}
