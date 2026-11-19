using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Bridge
{
    public class FormAppletlmpl : IFormulaireLmpl
    {
        public void dessineTexte()
        {
            Console.WriteLine("Affichage du formulaire d'immatriculation en Applet...");
        }
        public void gereZoneSaisie()
        {
            Console.WriteLine("Gestion de la saisie en Applet...");
        }
    }
}
